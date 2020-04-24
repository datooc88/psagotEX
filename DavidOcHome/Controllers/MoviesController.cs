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
            new Movie { Title = "Prison break", Img="",Seasons=5,Views=4500 },
            new Movie { Title = "Money Heist", Img="",Seasons=4,Views=1200 },
            new Movie { Title = "Breaking bad", Img="",Seasons=5,Views=683 },
            new Movie { Title = "Dexter",Img="",Seasons=8,Views=4782  }
        };

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/GetAllMovies")]
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public IHttpActionResult GetMovie(string title)
        {
            var movie = movies.FirstOrDefault((p) => p.Title.Contains(title));
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}
