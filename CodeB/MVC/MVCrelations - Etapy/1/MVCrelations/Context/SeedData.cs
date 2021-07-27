
using Microsoft.Extensions.DependencyInjection;
using MVCrelations.Context;
using MVCrelations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyMVC.Context
{
    public static class SeedData
    {
       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<Db>();
            context.Database.EnsureCreated();
            if (!context.Countrys.Any())
            {
                Country country = new Country();
                country.Name = "Country1";

                City city = new City();
                city.Name = "City11";
                country.Citys.Add(city);

                city = new City();
                city.Name = "City12";
                country.Citys.Add(city);
                context.Countrys.Add(country);
                context.SaveChanges();
            }
        }
    }
}
