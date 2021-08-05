using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace book.Models
{
    [JsonObject(IsReference = true)] 
    public class Order
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [JsonIgnore]
        [Column("user_id")]
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }

        public string status {get; set;}

        // Info
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("phone_number")]
        public string PhoneNumber {get; set;}
        [Required]
        [Column("address")]
        public string Address {get; set;}

        [Required]
        [Column("email")]
        public string Email { get; set; }
        public ICollection<CartItem> Cart { get; set; }
        public int Count {get; set;}
        public int Cost {get; set;}
    }
}