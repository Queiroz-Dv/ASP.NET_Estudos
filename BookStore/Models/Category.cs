using System.Collections.Generic;

namespace BookStore.Models
{
    public class Category
    {
        public Category()
        {
            //Start the collection
            this.Books = new List<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}