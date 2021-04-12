using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieListController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string[] imdbIds = new[]
        {
            "tt2140553", "tt9397284", "tt6161168", "tt0111161", "tt0068646", "tt0110912", "tt0137523", "tt0468569", "tt6161168", "tt2993508"
        };

        private readonly ILogger<MovieListController> _logger;

        public MovieListController(ILogger<MovieListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Movie> >Get()
        {
            //string omdbUri;
            client.DefaultRequestHeaders.Accept.Clear();

            List <Movie> movies= new List<Movie>();

            foreach(string Id in imdbIds)
            {
                var streamTask = client.GetStringAsync($"http://www.omdbapi.com/?i={Id}&apikey=2ec850f7");
                var msg = await streamTask;
                Movie movie = JsonSerializer.Deserialize<Movie>(msg);
                movies.Add(JsonSerializer.Deserialize<Movie>(msg));
            }

            return movies;
        }
    }
}
