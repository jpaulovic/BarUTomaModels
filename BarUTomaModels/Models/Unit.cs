using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Unit : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int UnitId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        [Required]
        [JsonProperty]
        public string Code { get; set; }
        [Required]
        [JsonProperty]
        public float MultiplierToBase { get; set; }
    }
}