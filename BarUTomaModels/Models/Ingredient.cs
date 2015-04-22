using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Ingredient : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<IngredientDrink> DrinksThatUseIngredient { get; set; } //1..m
        public virtual List<Bottle> Bottles { get; set; } //1..m
        [Required]
        public virtual Unit AlcoholContent { get; set; } //alcohol content in %
    }
}