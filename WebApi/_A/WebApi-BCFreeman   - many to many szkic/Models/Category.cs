using ManyToManyMVC.Models;
using System.Collections.Generic;
using WebApi_BCFreeman.Models;

namespace SportsStore.Models
{

    public class Category : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<ProductCategory> ProductCategorys { get; set; } = new List<ProductCategory>();
        
    }
}
