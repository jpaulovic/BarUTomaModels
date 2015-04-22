using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Event : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        //Navigation property
        [Required]
        public virtual Bar Bar { get; set; }
    }
}