using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Bar : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarId { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }

        //Navigation properties
        public virtual BarType BarType { get; set; }
        public virtual List<UserBar> Users { get; set; } //m..n, not needed?
        public virtual List<DrinkBar> DrinksOnBar { get; set; } //m..n
        public virtual List<Drink> Drinks { get; set; } //0..m
        public virtual List<Event> Events { get; set; } //1..m
        public virtual List<Order> Orders { get; set; } //1..m
    }
}