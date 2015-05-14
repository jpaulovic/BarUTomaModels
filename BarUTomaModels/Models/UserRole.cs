using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UserRole : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int UserRoleId { get; set; }
        /// <summary>
        /// Roles: 0 == super admin, 1 == bar owner, 2 == customer 
        /// </summary>
        [Required]
        [JsonProperty]
        public int Role { get; set; }

        public virtual List<ApplicationUser> Users { get; set; } //1..m
    }
}