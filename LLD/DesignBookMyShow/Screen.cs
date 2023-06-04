using LLD.DesignBookMyShow;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLD.DesignBookMyShow
{
    public class Screen
    {
        int screenId;
        List<Seat> seats = new List<Seat>();

        public int getScreenId()
        {
            return screenId;
        }

        public void setScreenId(int screenId)
        {
            this.screenId = screenId;
        }

        public List<Seat> getSeats()
        {
            return seats;
        }

        public void setSeats(List<Seat> seats)
        {
            this.seats = seats;
        }
    }
}
