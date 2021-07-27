using SportsStore.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_BCFreeman.Models
{
    public class ProductCategory
    { 
        [ForeignKey("Product")]
        public long ProductId       { get; set; }
        public Product Product      { get; set; }

        [ForeignKey("Category")]
        public long CategoryId      { get; set; }
        public Category Category    { get; set; }
   }
}
