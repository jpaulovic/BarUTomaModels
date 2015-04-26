using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarUTomaModels.Models
{
    public class UserRole : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }
        /// <summary>
        /// Roles: 0 == super admin, 1 == bar owner, 2 == customer 
        /// </summary>
        [Required]
        public int Role { get; set; }

        public virtual List<User> Users { get; set; } //1..m
    }
}