using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using VidlyExample.Models;

namespace VidlyExample.DTO
{
    public class MovieDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public byte StockNumber { get; set; }

        public byte GenreId { get; set; }

        public GenreDTO Genre { get; set; }
    }
}