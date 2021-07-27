using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCrelations.Models
{
    public class Country : EntityBase
    {
        public string Name { set; get; }
        public List<City> Citys { get; set; } = new List<City>();
    }
}
