using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Quantity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int QuantityId { get; set; }
        [Required]
        [JsonProperty]
        public decimal Amount { get; set; }
        [Required]
        [JsonProperty]
        public virtual Unit Unit { get; set; }
    }
}