﻿using LLD.DesignBookMyShow;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLD.DesignBookMyShow
{
    public class Booking
    {

        Show show;
        List<Seat> bookedSeats = new List<Seat>();
        Payment payment;

        public Show getShow()
        {
            return show;
        }

        public void setShow(Show show)
        {
            this.show = show;
        }

        public List<Seat> getBookedSeats()
        {
            return bookedSeats;
        }

        public void setBookedSeats(List<Seat> bookedSeats)
        {
            this.bookedSeats = bookedSeats;
        }

        public Payment getPayment()
        {
            return payment;
        }

        public void setPayment(Payment payment)
        {
            this.payment = payment;
        }
    }
}
