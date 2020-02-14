//created by Philipe Gouveia @ june 13th, 2019
//library management application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagApp.bus
{
    public class Book
    {
        #region //private variables related to the class books
        private string id;
        private string title;
        private string author;
        private string isbn;
        private Date edition = new Date();
        #endregion

        #region //setters and getters
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public Date Edition { get => edition; set => edition = value; }
        #endregion

        #region //constructor without args
        public Book()
        {
            this.id = "0000";
            this.title = "undefined";
            this.author = "undefined";
            this.isbn = "0000";
            this.edition.Day = 00;
            this.edition.Month = 00;
            this.edition.Year = 00;
        }
        #endregion

        #region //constructor with args
        public Book(string id, string tit, string aut, string isbn, int d, int m, int y)
        {
            this.id = id;
            this.title = tit;
            this.author = aut;
            this.isbn = isbn;
            this.edition.Day = d;
            this.edition.Month = m;
            this.edition.Year = y;
        }
        #endregion

        #region //override ToString method
        public override string ToString()
        {
            return ("Book:: id: " + this.id + "(ISBN: " + this.isbn+ ") - Title: " + this.title + " - by: " + this.author + " - edition: " + this.edition.ToString());
        }
        #endregion
    }
}
