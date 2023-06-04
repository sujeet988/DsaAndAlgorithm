using LLD.DesignBookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLD.DesignBookMyShow.Controller
{
    public class TheatreController
    {

        Dictionary<City, List<Theatre>> cityVsTheatre;
        List<Theatre> allTheatre;

        public TheatreController()
        {
            cityVsTheatre = new Dictionary<City, List<Theatre>>();
            allTheatre = new List<Theatre>();
        }

        public void addTheatre(Theatre theatre, City city)
        {

            allTheatre.Add(theatre);

            List<Theatre> theatres = cityVsTheatre[city];
            theatres.Add(theatre);
            cityVsTheatre.Add(city, theatres);
        }


        public Dictionary<Theatre, List<Show>> getAllShow(Movie movie, City city)
        {

            //get all the theater of this city

            Dictionary<Theatre, List<Show>> theatreVsShows = new Dictionary<Theatre, List<Show>>();

            List<Theatre> theatres = cityVsTheatre[city];

            //filter the theatres which run this movie

            foreach (Theatre theatre in theatres)
            {

                List<Show> givenMovieShows = new List<Show>();
                List<Show> shows = theatre.getShows();

                foreach (Show show in shows)
                {
                    if (show.movie.getMovieId() == movie.getMovieId())
                    {
                        givenMovieShows.Add(show);
                    }
                }
                if (givenMovieShows.Count > 0)
                {
                    theatreVsShows.Add(theatre, givenMovieShows);
                }
            }

            return theatreVsShows;
        }
    }
}
