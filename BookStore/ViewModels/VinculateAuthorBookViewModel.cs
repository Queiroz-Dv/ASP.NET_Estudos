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
        public long AuthorId { get; set; }

        [Required(ErrorMessage = "*")]
        public long BookId { get; set; }
    }
}