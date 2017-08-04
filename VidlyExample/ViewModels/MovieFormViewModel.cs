using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyExample.Models;
using System.ComponentModel.DataAnnotations;

namespace VidlyExample.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

       
        [Required]
        public string Name { get; set; }

       
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }


        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte? StockNumber { get; set; }


       
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }


        public string Title
        {
            get
            {
                return Id !=0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            StockNumber = movie.StockNumber;
            GenreId = movie.GenreId;
        }
    }
}