using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace book.Models
{
    public class Category
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<Book> BookCategories { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }

    [JsonObject(IsReference = true)] 
    public class SubCategory
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [JsonIgnore]
        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }

        public virtual ICollection<Book> BookSubCategories { get; set; }
    }
}