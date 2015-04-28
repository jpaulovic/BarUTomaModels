using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Event : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int EventId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        [Required]
        [JsonProperty]
        public string Info { get; set; }
        [Required]
        [JsonProperty]
        public DateTime DateTime { get; set; }
        //Navigation property
        [Required]
        public virtual Bar Bar { get; set; }
    }
}