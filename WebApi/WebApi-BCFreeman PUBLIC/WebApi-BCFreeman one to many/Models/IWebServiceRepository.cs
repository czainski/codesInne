namespace SportsStore.Models {

    public interface IWebServiceRepository {

        object GetProduct(long id);

        object GetProducts();

        long StoreProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(long id);
    }
}
