//project done by Philipe Gouveia @ June 19, 2019
//Midterm Test of Object Oriented Programming - 016T
//Build a Windows Form Movie Library App to train winform programming and aggregation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryApp.bus
{
    public class Duration
    {
        #region //class private attributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion

        #region //data properties
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }
        #endregion

        //parameteless contructor
        public Duration()
        {
            this.hours = 00;
            this.minutes = 00;
            this.seconds = 00;
        }

        //parameter constructor
        public Duration(int h, int m, int s)
        {
            this.hours = h;
            this.minutes = m;
            this.seconds = s;
        }

        //override ToString method
        public override string ToString()
        {
            return (this.hours + ":" + this.minutes + ":" + this.seconds);
        }
    }
}
