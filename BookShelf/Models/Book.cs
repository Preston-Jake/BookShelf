using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ISBN { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public string OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}
