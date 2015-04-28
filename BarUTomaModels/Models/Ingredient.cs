using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Ingredient : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int IngredientId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }

        public virtual List<IngredientDrink> DrinksThatUseIngredient { get; set; } //0..m
        public virtual List<Bottle> Bottles { get; set; } //0..m
        [JsonProperty]
        public virtual Unit AlcoholContent { get; set; } //alcohol content in %
    }
}