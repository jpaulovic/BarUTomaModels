
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class UserBar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserBarId { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual Bar Bar { get; set; }
        [Required]
        public virtual UserRole UserRole { get; set; }
    }
}