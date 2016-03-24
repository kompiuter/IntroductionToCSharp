using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class APIExample
    {
        /// <summary>
        /// Instructions on how to get your own api key can be found 
        /// in themoviedbinstructions.txt found in this project
        /// </summary>
        private static string ApiKey = "YOUR_API_KEY_HERE";

        public static async void Run()
        {
            var baseAddress = new Uri("http://api.themoviedb.org/3/");

            string jsonString;

            // This code will be taken from the website (it's supplied there)
            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                using (var response = await httpClient.GetAsync($"movie/now_playing?api_key={ApiKey}&page=1"))
                {
                    jsonString = await response.Content.ReadAsStringAsync();
                }
            }

            var movies = JObject.Parse(jsonString)["results"].ToObject<List<Movie>>();

            //var goodMovies = movies.Where(m => m.popularity > 7.5);
            //foreach (var movie in goodMovies)
            //{
            //    Console.WriteLine($"Name: {movie.original_title}");
            //    Console.WriteLine($"Rating: {movie.popularity}");
            //    Console.WriteLine();
            //}

            //var customMovies = movies.Where(m => m.original_title.StartsWith("t", StringComparison.CurrentCultureIgnoreCase));
            //foreach (var movie in customMovies)
            //{
            //    Console.WriteLine($"Name: {movie.original_title}");
            //    Console.WriteLine();
            //}

            //var alphabeticalMovies = movies.OrderBy(m => m.original_title);
            //foreach (var movie in alphabeticalMovies)
            //    Console.WriteLine($"Name: {movie.original_title}");

            //var moviesByRating = movies.OrderByDescending(m => m.popularity);
            //foreach (var movie in moviesByRating)
            //{
            //    Console.WriteLine($"Name: {movie.original_title}");
            //    Console.WriteLine($"Rating: {movie.popularity}");
            //    Console.WriteLine();
            //}

            //var groupedMovies = movies.OrderBy(m => m.release_date).GroupBy(m => m.release_date);
            //foreach (var group in groupedMovies)
            //{
            //    Console.WriteLine($"Release Date: {group.Key}");
            //    foreach (var movie in group)
            //        Console.WriteLine(movie.original_title);

            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }

    public class Movie
    {
        public string poster_path { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public int?[] genre_ids { get; set; }
        public int id { get; set; }
        public string original_title { get; set; }
        public string original_language { get; set; }
        public string title { get; set; }
        public string backdrop_path { get; set; }
        public float popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
    }
}
