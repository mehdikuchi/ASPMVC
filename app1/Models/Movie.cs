using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public String Name { get; set; }

        public Genre Genre { get; set; }

        public byte GenreTypeId { get; set; } // the foreign key for the reference data

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public byte InStock { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
    }
}