using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace book.Models
{   
    [JsonObject(IsReference = true)] 
    public class Book
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        
        public BookMeta BookMeta { get;set; }

        [JsonIgnore]
        [Column("sub_category_id")]
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        [JsonIgnore]
        public SubCategory SubCategory { get; set; }

        [JsonIgnore]
        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }

        [JsonIgnore]
        public virtual ICollection<CartItem> CartUsers { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}