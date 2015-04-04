using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Unit : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public float MultiplierToBase { get; set; }
    }
}