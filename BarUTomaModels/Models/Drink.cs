using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Drink : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }

        public virtual Bar Bar { get; set; }
        public virtual Quantity Price { get; set; }
        public virtual List<IngredientDrink> IngredientsUsed { get; set; } //1..m
        public virtual List<DrinkBar> BarsThatHaveThisDrink { get; set; } //m..n 
        public virtual List<OrderDrink> Orders { get; set; } //m..n
    }
}