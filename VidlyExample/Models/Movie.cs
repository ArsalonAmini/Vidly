using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace VidlyExample.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
       

        [Required]
        [Display(Name = "Date Movie Added")]
        public DateTime DateAdded { get; set; }
        

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public byte StockNumber { get; set; }
        

        public Genre Genre { get; set; }
        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        public byte NumberAvailable { get; set; }
       
    }
}