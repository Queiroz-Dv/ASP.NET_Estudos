using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid field")]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}