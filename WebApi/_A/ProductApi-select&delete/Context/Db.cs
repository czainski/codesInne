using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}