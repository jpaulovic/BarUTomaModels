using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int OrderId { get; set; }
        [Required]
        [JsonProperty]
        public DateTime DateTime { get; set; }

        [Required]
        public User User { get; set; }
        [Required]
        public Drink Drink{ get; set; }
        [Required]
        public Bar Bar { get; set; }
        [Required]
        public Quantity Price { get; set; }
        //one order can include multiple drinks
        public virtual List<OrderDrink> OrderDrinks { get; set; } //1..m+ 
    }
}