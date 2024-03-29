﻿using System;
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
        [JsonProperty]
        public string Place { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }
        [Required]
        public virtual Bar Bar { get; set; }
        [Required]
        [JsonProperty]
        public virtual Quantity Price { get; set; }
        //one order can include multiple drinks
        [JsonProperty]
        public virtual List<OrderDrink> OrderDrinks { get; set; } //1..m+ 
    }
}