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
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime DateTime { get; set; }
        //Navigation property
        public virtual Bar Bar { get; set; }
    }
}