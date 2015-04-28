using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Bottle : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int BottleId { get; set; }
        [Required]
        [JsonProperty]
        public DateTime BottleBought { get; set; } //when bottle was bought

        [Required]
        [JsonProperty]
        public Ingredient Ingredient { get; set; } //what is in the bottle
        [Required]
        [JsonProperty]
        public Quantity Quantity { get; set; } //how much there is left in the bottle
        [Required]
        [JsonProperty]
        public Bar Bar { get; set; }
    }
}