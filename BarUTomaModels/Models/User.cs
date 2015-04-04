using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BarUTomaServer.Models;

namespace BarUTomaModels.Models
{
    public class User : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; protected set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual Unit DefaultUnit { get; set; }
        public virtual List<UserBar> Bars { get; set; } //1..m
        public virtual List<Order> Orders { get; set; } //1..m
    }
}