//project done by Philipe Gouveia @ June 19, 2019
//Midterm Test of Object Oriented Programming - 016T
//Build a Windows Form Movie Library App to train winform programming and aggregation

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLibraryApp.bus;

namespace MovieLibraryApp
{
    public partial class Form1 : Form
    {
        #region //local variables
        ArrayList movieList = new ArrayList();
        int index = 0;
        #endregion

        //Form initialize method
        public Form1()
        {
            InitializeComponent();
        }

        /***********ADD BUTTON FUNCTION***********/
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Movie aMovie = new Movie();

            aMovie.Code = this.textBoxCode.Text;
            this.textBoxCode.Clear();

            aMovie.Title = this.textBoxTitle.Text;
            this.textBoxTitle.Clear();

            aMovie.Type = (movieType)this.comboBoxType.SelectedItem;
            this.comboBoxType.Text = " ";

            aMovie.Language = this.textBoxLanguage.Text;
            this.textBoxLanguage.Clear();

            aMovie.Actor = this.textBoxActor.Text;
            this.textBoxActor.Clear();

            aMovie.Duration.Hours = Convert.ToInt32(this.textBoxHours.Text);
            this.textBoxHours.Clear();

            aMovie.Duration.Minutes = Convert.ToInt32(this.textBoxMinutes.Text);
            //check if minutes inputed is greater than 60, thus adjust and to fit format HH:MIN
            if (aMovie.Duration.Minutes > 60)
            {
                MessageBox.Show("the minutes value inputed is higher than 60\nthe value was adjusted to fit the forma HH:MIN");
                int reminder = aMovie.Duration.Minutes;
                aMovie.Duration.Minutes = aMovie.Duration.Minutes % 60;
                aMovie.Duration.Hours = aMovie.Duration.Hours + (reminder - aMovie.Duration.Minutes % 60)/60;
            }
            this.textBoxMinutes.Clear();

            aMovie.Duration.Seconds = Convert.ToInt32(this.textBoxSeconds.Text);
            //check if seconds inputed is higher than 60, thus adjust and to fit format MIN:SEC
            if (aMovie.Duration.Seconds > 60)
            {
                MessageBox.Show("the seconds value inputed is higher than 60\nthe value was adjusted to fit the forma MIN:SEC");
                int reminder = aMovie.Duration.Seconds;
                aMovie.Duration.Seconds = aMovie.Duration.Seconds % 60;
                aMovie.Duration.Minutes = aMovie.Duration.Minutes + (reminder - aMovie.Duration.Seconds % 60) / 60;
            }
            this.textBoxSeconds.Clear();

            aMovie.Year = Convert.ToInt32(this.textBoxYear.Text);
            this.textBoxYear.Clear();

            movieList.Add(aMovie);

            MessageBox.Show("Added");
            this.listBoxMovies.Items.Add(aMovie);

            this.textBoxCode.Focus();
        }

        /***********UPDATE BUTTON FUNCTION***********/
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Movie updateItem = new Movie();

            updateItem.Code = this.textBoxCode.Text;
            this.textBoxCode.Clear();
            updateItem.Title = this.textBoxTitle.Text;
            this.textBoxTitle.Clear();
            updateItem.Type = (movieType)this.comboBoxType.SelectedItem;
            this.comboBoxType.Text = " ";
            updateItem.Language = this.textBoxLanguage.Text;
            this.textBoxLanguage.Clear();
            updateItem.Actor = this.textBoxActor.Text;
            this.textBoxActor.Clear();
            updateItem.Duration.Hours = Convert.ToInt32(this.textBoxHours.Text);
            this.textBoxHours.Clear();
            updateItem.Duration.Minutes = Convert.ToInt32(this.textBoxMinutes.Text);
            this.textBoxMinutes.Clear();
            updateItem.Duration.Seconds = Convert.ToInt32(this.textBoxSeconds.Text);
            this.textBoxSeconds.Clear();
            updateItem.Year = Convert.ToInt32(this.textBoxYear.Text);
            this.textBoxYear.Clear();

            movieList[index] = updateItem;

            this.listBoxMovies.Items.Clear();

            foreach (Movie element in movieList)
            {
                this.listBoxMovies.Items.Add(element);   
            }

            this.textBoxCode.Focus();
        }

        /***********DISPLAY BUTTON FUNCTION***********/
        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            if (movieList.Count == 0)
            {
                MessageBox.Show("Your invetory is empty");
            }
            else
            {
                this.listBoxMovies.Items.Clear();

                foreach (Movie element in movieList)
                {
                    this.listBoxMovies.Items.Add(element);
                }
            }

            this.textBoxCode.Focus();
        }

        /***********REMOVE BUTTON FUNCTION***********/
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            movieList.RemoveAt(index);

            MessageBox.Show("Item Removed");

            this.listBoxMovies.Items.Clear();

            foreach (Movie element in movieList)
            {
                this.listBoxMovies.Items.Add(element);
            }

            this.textBoxCode.Clear();
            this.textBoxTitle.Clear();
            this.comboBoxType.Text = " ";
            this.textBoxLanguage.Clear();
            this.textBoxActor.Clear();
            this.textBoxHours.Clear();
            this.textBoxMinutes.Clear();
            this.textBoxSeconds.Clear();
            this.textBoxYear.Clear();

            this.textBoxCode.Focus();
        }

        /***********EXIT BUTTON FUNCTION***********/
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye");
            this.Close();
        }

        /***********SEARCH BUTTON FUNCTION***********/
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
                string searchinput = this.textBoxSearch.Text;
                bool found = false;

            if (movieList.Count == 0)
            {
                MessageBox.Show("Your invetory is empty");
            }
            else
            {
                this.listBoxMovies.Items.Clear();

                foreach (Movie element in movieList)
                {
                    if ((searchinput == element.Code) || (searchinput == element.Title) || (searchinput == element.Type.ToString()) || (searchinput == element.Language) || (searchinput == element.Actor)
                        || (searchinput == element.Year.ToString()))
                    {
                        this.listBoxMovies.Items.Add(element);
                        found = true;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("No items found in the invetory with the inputed parameter");
                }
            }

            this.textBoxSearch.Clear();

            this.textBoxCode.Focus();
        }

        /***********REFRESH BUTTON FUNCTION***********/
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.listBoxMovies.Items.Clear();
            this.textBoxCode.Clear();
            this.textBoxTitle.Clear();
            this.comboBoxType.Text = " ";
            this.textBoxLanguage.Clear();
            this.textBoxActor.Clear();
            this.textBoxHours.Clear();
            this.textBoxMinutes.Clear();
            this.textBoxSeconds.Clear();
            this.textBoxYear.Clear();

            this.textBoxCode.Focus();
        }

        /**********SELECT INDEX ON LIST*************/
        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxMovies.SelectedIndex;

            MessageBox.Show("Selected item index: " + index);

            Movie selecteditem = (Movie)movieList[index];

            this.textBoxCode.Text = selecteditem.Code;
            this.textBoxTitle.Text = selecteditem.Title;
            this.comboBoxType.Text = selecteditem.Type.ToString();            
            this.textBoxLanguage.Text = selecteditem.Language;            
            this.textBoxActor.Text = selecteditem.Actor;            
            this.textBoxHours.Text = selecteditem.Duration.Hours.ToString();            
            this.textBoxMinutes.Text  = selecteditem.Duration.Minutes.ToString();            
            this.textBoxSeconds.Text = selecteditem.Duration.Seconds.ToString();
            this.textBoxYear.Text = selecteditem.Year.ToString();

            this.textBoxCode.Focus();
        }

        /***********CHANGE SKIN BUTTON FUNCTION*********/
        private void ButtonSkin_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.SystemColors.ButtonFace)
            {
                this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.ForeColor = System.Drawing.SystemColors.ControlLightLight;

            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            }
        }

        /*********** COMBO BOX OF MOVIE TYPES *********/
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (movieType element in Enum.GetValues(typeof(movieType)))
            {
                this.comboBoxType.Items.Add(element);
            }
        }
    }
}
