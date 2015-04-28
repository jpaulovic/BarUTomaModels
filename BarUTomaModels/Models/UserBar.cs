
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UserBar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int UserBarId { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual Bar Bar { get; set; }
        [Required]
        public virtual UserRole UserRole { get; set; }
    }
}