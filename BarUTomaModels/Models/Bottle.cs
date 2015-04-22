using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Bottle : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BottleId { get; set; }
        public DateTime DateTime { get; set; } //when bottle was bought

        public Ingredient Ingredient { get; set; }
        public Quantity Quantity { get; set; }
    }
}