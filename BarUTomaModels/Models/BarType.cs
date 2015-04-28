using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BarType : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int BarTypeId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        //list of bars of given type
        //public virtual List<Bar> Bars { get; set; } 
    }
}