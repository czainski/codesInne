using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCrelations.Models
{
    public class IDcard : EntityBase
    {
        public string Name { set; get; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}
