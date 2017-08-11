using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyExample.DTO;
using VidlyExample.Models;

namespace VidlyExample.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }


        //[HttpPost]
        //public IHttpaction CreateRental (NewRentalDTO newRental)
        //{
        //    movie = _context.Movies.SingleOrDefault(m=>m.Name),
        //    customer = _context.Customers.FirstOrDefault(c.id == c.customers)

        //    rental = new Rental
        //    {
        //        Movie = Rental.movie,
        //        Customer = Rental.customer
        //    }

        //}

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRental)
        {

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));
            
            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}
