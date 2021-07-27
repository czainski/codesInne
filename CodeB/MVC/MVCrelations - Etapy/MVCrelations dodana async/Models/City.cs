using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCrelations.Models
{
    public class City : EntityBase
    {
        public string Name { set; get; }

        public Country Country { get; set; }
    }
}
