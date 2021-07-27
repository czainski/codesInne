using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCrelations.Models
{
    public class Person : EntityBase
    {
        public string Name { set; get; }
        public IDcard IDcard { get; set; }
    }
}
