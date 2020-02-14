//created by Philipe Gouveia @ june 18th, 2019
//library management application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagApp.bus
{
    public class Date
    {
        #region //private variables
        private int day;
        private int month;
        private int year;
        #endregion

        #region //class parameterless constructor
        public Date()
        {
            this.day = 00;
            this.month = 00;
            this.year = 0000;
        }
        #endregion
        
        #region //class parameter constructor
        public Date(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }
        #endregion

        #region //variables properties
        public int Day { get => this.day; set => this.day = value; }
        public int Month { get => this.month; set => this.month = value; }
        public int Year { get => this.year; set => this.year = value; }
        #endregion

        #region //toString override
        public override string ToString()
        {
            return (this.day + "/" + this.month + "/" + this.year);
        }
        #endregion
    }
}
