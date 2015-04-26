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
        [Required]
        public DateTime BottleBought { get; set; } //when bottle was bought

        [Required]
        public Ingredient Ingredient { get; set; } //what is in the bottle
        [Required]
        public Quantity Quantity { get; set; } //how much there is left in the bottle
    }
}