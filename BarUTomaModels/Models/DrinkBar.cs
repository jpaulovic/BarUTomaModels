
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DrinkBar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int DrinkBarId { get; set; }
        [JsonProperty]
        public string Info { get; set; }
        
        [Required]
        [JsonProperty]
        public Drink Drink { get; set; }
        [Required]
        [JsonProperty]
        public Bar Bar { get; set; }
        [Required]
        [JsonProperty]
        public Quantity Price { get; set; }
    }
}