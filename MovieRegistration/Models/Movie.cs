using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Need to enter between 1-50 characters.")]
        [MaxLength]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

        public Movie() { }
        public Movie(string Title, string Genre, int Year, string Actors, string Directors)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Actors = Actors;
            this.Directors = Directors;
        }
    }
}
