using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class BarType : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarTypeId { get; set; }
        public string Name { get; set; }
        //list of bars of given type
        //public virtual List<Bar> Bars { get; set; } 
    }
}