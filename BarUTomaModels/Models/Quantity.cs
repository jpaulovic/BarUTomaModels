using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Quantity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuantityId { get; set; }
        [Required]
        public int Amount { get; set; }

        [Required]
        public Unit Unit { get; set; }
    }
}