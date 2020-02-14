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
    class Movie
    {
        #region //class private attributes
        private string code;
        private string title;
        private movieType type;
        private string language;
        private string actor;
        private int year;
        Duration duration;
        #endregion

        #region //data properties
        public Duration Duration { get => duration; set => duration = value; }
        public string Code { get => this.code; set => this.code = value; }
        public string Title { get => title; set => title = value; }
        public movieType Type { get => type; set => type = value; }
        public string Language { get => language; set => language = value; }
        public string Actor { get => actor; set => actor = value; }
        public int Year { get => year; set => year = value; }
        #endregion

        //parameteless constructor
        public Movie()
        {
            this.code = "undefined";
            this.title = "undefined";
            this.type = movieType.Default;
            this.language = "undefined";
            this.actor = "undefined";
            this.year = 0000;
            duration = new Duration();
        }

        //parameter constructor 1
        public Movie(string cd, string tit, movieType typ, string lang, string act, int year)
        {
            this.code = cd;
            this.title = tit;
            this.type = typ;
            this.language = lang;
            this.actor = act;
            this.year = year;
            duration = new Duration();
        }

        //paramenter constructor 2
        public Movie(string cd, string tit, movieType typ, string lang, string act, int year, Duration dur)
        {
            this.code = cd;
            this.title = tit;
            this.type = typ;
            this.language = lang;
            this.actor = act;
            this.year = year;
            duration = dur;
        }

        //override ToString method
        public override string ToString()
        {
            return ("Movie:: Code: " + this.code + " - " + this.title + " - " + this.type + " - " + this.language + " - " + this.actor + " - " + this.year + " - " + this.duration);
        }
    }
}
