
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OrderDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int OrderDrinkId { get; set; }
        [Required]
        public virtual Order Order { get; set; }
        [Required]
        [JsonProperty]
        public virtual Drink Drink { get; set; }
        [JsonProperty]
        [Required]
        public virtual Quantity Quantity { get; set; }
    }
}