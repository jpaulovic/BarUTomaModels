using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IngredientDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int IngredientDrinkId { get; set; }
        [Required]
        [JsonProperty]
        public virtual Ingredient Ingredient { get; set; }
        [Required]
        public virtual Drink Drink { get; set; }
        [Required]
        [JsonProperty]
        public virtual Quantity Quantity { get; set; }
    }
}