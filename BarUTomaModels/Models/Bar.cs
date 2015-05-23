using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Bar : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int BarId { get; set; }
        [Required]
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Info { get; set; }
        [Required]
        [JsonProperty]
        public virtual BarType BarType { get; set; }
        [Required]
        [JsonProperty]
        public virtual Address Address { get; set; }
        [Required]
        [JsonProperty]
        public DateTime DateCreated { get; set; }
        [Required]
        [JsonProperty]
        public DateTime DateModified { get; set; }

        //Navigation properties

        public virtual List<UserBar> Users { get; set; } //m..n
        public virtual List<DrinkBar> DrinksOnBar { get; set; } //m..n
        public virtual List<Drink> Drinks { get; set; } //0..m
        public virtual List<Event> Events { get; set; } //1..m
        public virtual List<Order> Orders { get; set; } //1..m
        public virtual List<Tuple<Ingredient, Quantity>> IngredientsAvailable { get; set; } //0..m
    }
}