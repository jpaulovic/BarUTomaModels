using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class IngredientDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientDrinkId { get; set; }
        [Required]
        public Ingredient Ingredient { get; set; }
        [Required]
        public Drink Drink { get; set; }
        [Required]
        public Quantity Quantity { get; set; }
    }
}