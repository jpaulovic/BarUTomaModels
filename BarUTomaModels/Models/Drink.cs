using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Drink : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int DrinkId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        [Required]
        [JsonProperty]
        public string Info { get; set; }
        [Required]
        [JsonProperty]
        public virtual Quantity Price { get; set; }

        public virtual Bar Bar { get; set; }
        public virtual List<IngredientDrink> IngredientsUsed { get; set; } //1..m
        public virtual List<DrinkBar> BarsThatHaveThisDrink { get; set; } //m..n 
        public virtual List<OrderDrink> Orders { get; set; } //m..n
    }
}