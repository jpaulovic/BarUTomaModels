
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class DrinkBar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DrinkBarId { get; set; }
        public string Info { get; set; }
        
        [Required]
        public virtual Drink Drink { get; set; }
        [Required]
        public virtual Bar Bar { get; set; }
        [Required]
        public virtual Quantity Price { get; set; }
    }
}