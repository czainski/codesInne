using System.Collections.Generic;
using System.Linq;
using ManyToManyMVC.Context;
using Microsoft.EntityFrameworkCore;
using WebApi_BCFreeman.Models;

namespace SportsStore.Models {

    public class WebServiceRepository : IWebServiceRepository {
        private Db context;

        public WebServiceRepository(Db ctx)
        {
            context = ctx;
            
        }

        public object GetProduct(long id) {
            return context.Products.Include(p=> p.ProductCategorys)
                .ThenInclude(e=>e.Category)      
                .FirstOrDefault(p => p.Id == id);


        }
        Dictionary<Category, Product> listProductCategory = new Dictionary<Category, Product>();
     

        public object GetProducts() {
            List<Product> listProduct = context.Products.Include(ps => ps.ProductCategorys)
                            .ThenInclude(c => c.Category).ToList();


            foreach (Product p in listProduct)
            {
                foreach (ProductCategory pc in p.ProductCategorys)
                {
                     listProductCategory.Add(pc.Category, p); 
                }
            }
            return listProductCategory;
                //context.Products.Include(p => p.ProductCategorys)
                //.ThenInclude(e => e.Category);
        }

        public long StoreProduct(Product product) {
            context.Products.Add(product);
            context.SaveChanges();
            return product.Id;
        }

        public void UpdateProduct(Product product) {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(long id) {
            context.Products.Remove(new Product { Id = id });
            context.SaveChanges();
        }
    }
}
