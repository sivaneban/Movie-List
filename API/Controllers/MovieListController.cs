using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;
using Application;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieListController : ControllerBase
    {
       

        private readonly ILogger<MovieListController> _logger;

        public MovieListController(ILogger<MovieListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Task<List<Movie>> Get()
        {
            return MovieService.getMovieList();
        }
    }
}
