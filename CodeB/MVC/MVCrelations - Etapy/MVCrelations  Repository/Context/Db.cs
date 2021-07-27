using Microsoft.EntityFrameworkCore;
using MVCrelations.Models;

namespace MVCrelations.Context
{
    public class Db : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-HRI2K4I;Database=OneAndOneManyRelation;Integrated Security=True");
        }
        public DbSet<City>    Citys    { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<IDcard>  IDcards  { get; set; }
        public DbSet<Person>  Persons  { get; set; }
    }
}
/*
 Microsoft.EntityFrameworkCore

 Windows Authorisation
 add-migration BcMigration
 update-database –verbose
 */

