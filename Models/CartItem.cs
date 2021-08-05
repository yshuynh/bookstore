using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace book.Models
{
    
    [JsonObject(IsReference = true)]
    public class CartItem
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("book_id")]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }


        [Column("user_id")]
        public int? UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int Count {get; set;}

        [JsonIgnore]
        [Column("order_id")]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
    }
}