using System.ComponentModel.DataAnnotations;

namespace ManyToManyMVC.Models
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
