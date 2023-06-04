using LLD.DesignBookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLD.DesignBookMyShow.Controller
{
    public class MovieController
    {
        Dictionary<City, List<Movie>> cityVsMovies;
        List<Movie> allMovies;

       public MovieController()
        {
            cityVsMovies = new Dictionary<City, List<Movie>>();
            allMovies = new List<Movie>();
        }


        //ADD movie to a particular city, make use of cityVsMovies map
       public void addMovie(Movie movie, City city)
        {

            allMovies.Add(movie);
            List<Movie> movies = cityVsMovies[city];
            movies.Add(movie);
            cityVsMovies.Add(city, movies);
        }


      public  Movie getMovieByName(String movieName)
        {

            foreach (Movie movie in allMovies)
            {
                if ((movie.getMovieName()).Equals(movieName))
                {
                    return movie;
                }
            }
            return null;
        }


       public List<Movie> getMoviesByCity(City city)
        {
            return cityVsMovies[city];
        }
        //REMOVE movie from a particular city, make use of cityVsMovies map

        //UPDATE movie of a particular city, make use of cityVsMovies map

        //CRUD operation based on Movie ID, make use of allMovies list
    }
}
