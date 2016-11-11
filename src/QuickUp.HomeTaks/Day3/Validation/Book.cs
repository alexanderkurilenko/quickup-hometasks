using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Validation
{
    public enum Genre
    {
        Classic,Sciense,Adventure,Novel
    }
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [ClassicBook(1900)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public bool Preorder { get; set; }

    }
}
