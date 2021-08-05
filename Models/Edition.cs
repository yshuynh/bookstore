using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book.Models
{
    public class Edition
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        
    }
}