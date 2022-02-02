using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.ViewModels
{
    public class VinculateAuthorBookViewModel
    {
        [Required(ErrorMessage = "*")]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "*")]
        public int BookId { get; set; }
    }
}