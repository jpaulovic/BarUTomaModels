
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
        public virtual ApplicationUser User { get; set; }
        [Required]
        public virtual Bar Bar { get; set; }
        [JsonProperty]
        [Required]
        public virtual int UserRole { get; set; }
    }
}