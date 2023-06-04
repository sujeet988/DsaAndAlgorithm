using LLD.DesignBookMyShow.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLD.DesignBookMyShow
{
    public class Theatre
    {
        int theatreId;
        String address;
        City city;
        List<Screen> screen = new List<Screen>();
        List<Show> shows = new List<Show>();

        public int getTheatreId()
        {
            return theatreId;
        }

        public void setTheatreId(int theatreId)
        {
            this.theatreId = theatreId;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public List<Screen> getScreen()
        {
            return screen;
        }

        public void setScreen(List<Screen> screen)
        {
            this.screen = screen;
        }

        public List<Show> getShows()
        {
            return shows;
        }

        public void setShows(List<Show> shows)
        {
            this.shows = shows;
        }

        public City getCity()
        {
            return city;
        }

        public void setCity(City city)
        {
            this.city = city;
        }
    }
}
