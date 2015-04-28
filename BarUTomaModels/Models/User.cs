using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class User : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int UserId { get; protected set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        [Required]
        [JsonProperty]
        public string Email { get; set; }
        [Required]
        [JsonProperty]
        public string Password { get; set; }

        [Required]
        [JsonProperty]
        public virtual Unit DefaultUnit { get; set; }
        public virtual List<UserBar> Bars { get; set; } //1..m
        public virtual List<Order> Orders { get; set; } //1..m
    }
}