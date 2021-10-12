using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext context;

        public NewRentalsController()
        {
            context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = context.Customers.Single(
    c => c.Id == newRental.CustomerId);

            var movies = context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.numberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.numberAvailable--;

                customer.MoviesAdded++;

                if (customer.MoviesAdded > customer.RentedMoviesLimit)
                    return BadRequest("Customer has exceeded rented movies limit.");

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                context.Rentals.Add(rental);
            }

            context.SaveChanges();

            return Ok();
        }
    }
}
