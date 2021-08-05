using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book.Models
{
    public class Rating
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("user_id")]       
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("rate")]   
        public int Rate { get; set; }
    }

}