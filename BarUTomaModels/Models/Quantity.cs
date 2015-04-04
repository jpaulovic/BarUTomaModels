using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Quantity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuantityId { get; set; }
        public int Amount { get; set; }

        public Unit Unit { get; set; }
    }
}