using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte InStock { get; set; }
        public DateTime DateAdded { get; set; }
    }
}