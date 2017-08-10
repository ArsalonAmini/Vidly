using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyExample.Models;
using System.ComponentModel.DataAnnotations;

namespace VidlyExample.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }

    }
}