using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }

        public User User { get; set; }
        public Drink Drink{ get; set; }
        public Bar Bar { get; set; }
        public Quantity Price { get; set; }
        //one order can include multiple drinks
        public virtual List<OrderDrink> OrderDrinks { get; set; } //1..m+ 
    }
}