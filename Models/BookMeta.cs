using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;


namespace book.Models
{
    [JsonObject(IsReference = true)] 
    public class BookMeta
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Column("author_id")]
        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }

        [Required]
        [JsonIgnore]
        [Column("book_id")]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [JsonIgnore]
        public Book Book { get; set; }

        [Required]
        [Column("price")]
        public int Price { get; set; }

        [Required]
        [Column("original_price")]
        public int OriginalPrice { get; set; }

        [Required]
        [Column("discount_percent")]
        public int DiscountPercent { get; set; }

        [Required]
        [Column("publisher_id")]
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        [Required]
        [Column("bg_url")]
        public string BgUrl { get; set; }

        [Column("description")]
        public string Description { get; set; }
        [Column("cover_form")]
        public string CoverForm { get; set; }
    }
}