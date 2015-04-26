using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace BarUTomaModels.Models
{
    public class Bar : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Info { get; set; }

        //Navigation properties
        [Required]
        public virtual BarType BarType { get; set; }
        public virtual List<UserBar> Users { get; set; } //m..n
        public virtual List<DrinkBar> DrinksOnBar { get; set; } //m..n
        public virtual List<Drink> Drinks { get; set; } //0..m
        public virtual List<Event> Events { get; set; } //1..m
        public virtual List<Order> Orders { get; set; } //1..m
        public virtual List<Tuple<Ingredient, Quantity>> IngredientsAvailable { get; set; } //0..m
        [Required]
        public virtual Address Address { get; set; }
    }
}