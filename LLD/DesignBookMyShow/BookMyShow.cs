using LLD.DesignBookMyShow.Controller;
using LLD.DesignBookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LLD.DesignBookMyShow
{
    internal class BookMyShow
    {


       private readonly MovieController movieController;
       private readonly TheatreController theatreController;

        BookMyShow()
        {
            movieController = new MovieController();
            theatreController = new TheatreController();
        }


        public static void Main(String[] args)
        {
            Console.WriteLine("Book my show starts");

            BookMyShow bookMyShow = new BookMyShow();

            bookMyShow.initialize();

            //user1
            bookMyShow.createBooking(City.Bangalore, "BAAHUBALI");
            //user2
            bookMyShow.createBooking(City.Bangalore, "BAAHUBALI");

        }

        private void createBooking(City userCity, String movieName)
        {


            //1. search movie by my location
            List<Movie> movies = movieController.getMoviesByCity(userCity);

            //2. select the movie which you want to see. i want to see Baahubali
            Movie interestedMovie = null;
            foreach (Movie movie in movies)
            {

                if ((movie.getMovieName()).Equals(movieName))
                {
                    interestedMovie = movie;
                }
            }

            //3. get all show of this movie in Bangalore location
            Dictionary<Theatre, List<Show>> showsTheatreWise = theatreController.getAllShow(interestedMovie, userCity);

            //4. select the particular show user is interested in
            //// var entry = showsTheatreWise.;
            List<Show> runningShows = new List<Show>();
            Show interestedShow = runningShows[0];

            //5. select the seat
            int seatNumber = 30;
            List<int> bookedSeats = interestedShow.getBookedSeatIds();
            if (!bookedSeats.Contains(seatNumber))
            {
                bookedSeats.Add(seatNumber);
                //startPayment
                Booking booking = new Booking();
                List<Seat> myBookedSeats = new List<Seat>();
                foreach (Seat screenSeat in interestedShow.getScreen().getSeats())
                {
                    if (screenSeat.getSeatId() == seatNumber)
                    {
                        myBookedSeats.Add(screenSeat);
                    }
                }
                booking.setBookedSeats(myBookedSeats);
                booking.setShow(interestedShow);
            }
            else
            {
                //throw exception
               Console.WriteLine("seat already booked, try again");
                return;
            }

            Console.WriteLine("BOOKING SUCCESSFUL");
        }

        private void initialize()
        {

            //create movies
            createMovies();

            //create theater with screens, seats and shows
            createTheatre();
        }

        //creating 2 theatre
        private void createTheatre()
        {

            Movie avengerMovie = movieController.getMovieByName("AVENGERS");
            Movie baahubali = movieController.getMovieByName("BAAHUBALI");

            Theatre inoxTheatre = new Theatre();
            inoxTheatre.setTheatreId(1);
            inoxTheatre.setScreen(createScreen());
            inoxTheatre.setCity(City.Bangalore);
            List<Show> inoxShows = new List<Show>();
            Show inoxMorningShow = createShows(1, inoxTheatre.getScreen()[0], avengerMovie, 8);
            Show inoxEveningShow = createShows(2, inoxTheatre.getScreen()[0], baahubali, 16);
            inoxShows.Add(inoxMorningShow);
            inoxShows.Add(inoxEveningShow);
            inoxTheatre.setShows(inoxShows);


            Theatre pvrTheatre = new Theatre();
            pvrTheatre.setTheatreId(2);
            pvrTheatre.setScreen(createScreen());
            pvrTheatre.setCity(City.Delhi);
            List<Show> pvrShows = new List<Show>();
            Show pvrMorningShow = createShows(3, pvrTheatre.getScreen()[0], avengerMovie, 13);
            Show pvrEveningShow = createShows(4, pvrTheatre.getScreen()[0], baahubali, 20);
            pvrShows.Add(pvrMorningShow);
            pvrShows.Add(pvrEveningShow);
            pvrTheatre.setShows(pvrShows);

            theatreController.addTheatre(inoxTheatre, City.Bangalore);
            theatreController.addTheatre(pvrTheatre, City.Delhi);

        }

        private List<Screen> createScreen()
        {

            List<Screen> screens = new List<Screen>();
            Screen screen1 = new Screen();
            screen1.setScreenId(1);
            screen1.setSeats(createSeats());
            screens.Add(screen1);

            return screens;
        }

        private Show createShows(int showId, Screen screen, Movie movie, int showStartTime)
        {

            Show show = new Show();
            show.setShowId(showId);
            show.setScreen(screen);
            show.setMovie(movie);
            show.setShowStartTime(showStartTime); //24 hrs time ex: 14 means 2pm and 8 means 8AM
            return show;
        }

        //creating 100 seats
        private List<Seat> createSeats()
        {

            //creating 100 seats for testing purpose, this can be generalised
            List<Seat> seats = new List<Seat>();

            //1 to 40 : SILVER
            for (int i = 0; i < 40; i++)
            {
                Seat seat = new Seat();
                seat.setSeatId(i);
                seat.setSeatCategory(SeatCategory.SILVER);
                seats.Add(seat);
            }

            //41 to 70 : SILVER
            for (int i = 40; i < 70; i++)
            {
                Seat seat = new Seat();
                seat.setSeatId(i);
                seat.setSeatCategory(SeatCategory.GOLD);
                seats.Add(seat);
            }

            //1 to 40 : SILVER
            for (int i = 70; i < 100; i++)
            {
                Seat seat = new Seat();
                seat.setSeatId(i);
                seat.setSeatCategory(SeatCategory.PLATINUM);
                seats.Add(seat);
            }

            return seats;
        }

        private void createMovies()
        {

            //create Movies1
            Movie avengers = new Movie();
            avengers.setMovieId(1);
            avengers.setMovieName("AVENGERS");
            avengers.setMovieDuration(128);

            //create Movies2
            Movie baahubali = new Movie();
            baahubali.setMovieId(2);
            baahubali.setMovieName("BAAHUBALI");
            baahubali.setMovieDuration(180);


            //add movies against the cities
            movieController.addMovie(avengers, City.Bangalore);
            movieController.addMovie(avengers, City.Delhi);
            movieController.addMovie(baahubali, City.Bangalore);
            movieController.addMovie(baahubali, City.Delhi);
        }


    }
}
