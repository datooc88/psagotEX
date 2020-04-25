using DavidOcHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DavidOcHome.Controllers
{
    public class MoviesController : ApiController
    {
        Movie[] movies = new Movie[]
        {
            new Movie { Id=1, Title = "Prison break", Img="",Seasons=5,Views=4500 },
            new Movie { Id=2, Title = "Money Heist", Img="",Seasons=4,Views=1200 },
            new Movie { Id=3, Title = "Breaking bad", Img="",Seasons=5,Views=683 },
            new Movie { Id=4, Title = "Dexter",Img="",Seasons=8,Views=4782  }
        };

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/GetAllMovies")]
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/GetMovie/{id}")]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = movies.FirstOrDefault((p) => p.Id==id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}
