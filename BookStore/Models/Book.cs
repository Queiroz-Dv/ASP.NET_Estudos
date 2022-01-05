using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new List<Author>();
        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Invalid field")]
        public string ISBN { get; set; }

        [Required(ErrorMessage ="*")]
        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}