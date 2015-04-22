
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class OrderDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDrinkId { get; set; }
        [Required]
        public virtual Order Order { get; set; }
        [Required]
        public virtual Drink Drink { get; set; }
        [Required]
        public virtual Quantity Quantity { get; set; }
    }
}