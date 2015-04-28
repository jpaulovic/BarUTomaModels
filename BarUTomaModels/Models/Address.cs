using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BarUTomaModels.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Address : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty]
        public int AddressId { get; set; }
        [Required]
        [JsonProperty]
        public string StreetWithNumber { get; set; }
        [Required]
        [JsonProperty]
        public string City { get; set; }
        [Required]
        [JsonProperty]
        public string PostCode { get; set; }
        [Required]
        [JsonProperty]
        public string Country { get; set; }
    }
}
