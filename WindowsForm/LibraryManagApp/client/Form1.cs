//created by Philipe Gouveia @ june 13th, 2019
//library management application

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagApp.bus;

namespace LibraryManagApp
{
    public partial class Form1 : Form
    {
        #region //local variables
        ArrayList listofBooks = new ArrayList();
        int index = 0;
        #endregion 

        public Form1()
        {
            InitializeComponent();
        }

        /////////////////// ADD button
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
            aBook.Id = this.textBoxID.Text;
            aBook.Title = this.textBoxTitle.Text;
            aBook.Author = this.textBoxAuthor.Text;
            aBook.Isbn = this.textBoxISBN.Text;
            aBook.Edition.Day = Convert.ToInt32(this.textBoxEditionDay.Text);
            aBook.Edition.Month = Convert.ToInt32(this.textBoxEditionMonth.Text);
            aBook.Edition.Year = Convert.ToInt32(this.textBoxEditionYear.Text);

            MessageBox.Show(aBook.ToString());

            this.listofBooks.Add(aBook);

            this.textBoxID.Text = "";
            this.textBoxTitle.Text = "";
            this.textBoxAuthor.Text = "";
            this.textBoxISBN.Text = "";
            this.textBoxEditionDay.Text = "";
            this.textBoxEditionMonth.Text = "";
            this.textBoxEditionYear.Text = "";

            this.textBoxID.Focus();
        }

        /////////////////// DISPLAY button
        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            if (listofBooks.Count != 0)
            {
                this.listBoxBooks.Items.Clear();

                for (int index = 0; index < this.listofBooks.Count; index++)
                {
                    this.listBoxBooks.Items.Add(this.listofBooks[index]);
                }
            }
            else { MessageBox.Show("There is no data in the library inventory"); } 
        }

        /////////////////// REFRESH button
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.listBoxBooks.Items.Clear();
            this.textBoxID.Focus();
        }

        /////////////////// DELETE button   ((((REVIEW))))
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            string message = "Do you want to remove the book from the inventory?";
            string caption = "Removing Book";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.listofBooks.RemoveAt(index);
                MessageBox.Show("Book index " + ++index + " removed");
                this.listBoxBooks.Items.Clear();

                if (listofBooks.Count != 0)
                {
                    this.listBoxBooks.Items.Clear();

                    for (int index = 0; index < this.listofBooks.Count; index++)
                    {
                        this.listBoxBooks.Items.Add(this.listofBooks[index]);
                    }
                }
                else { MessageBox.Show("There is no data in the library inventory"); }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Book index " + ++index + "NOT removed");
            }
        }

        /////////////////// UPDATE button
        private void ButtonUpdt_Click(object sender, EventArgs e)
        {
            Book modifiedbook = new Book();
            modifiedbook.Id = this.textBoxID.Text;
            modifiedbook.Title = this.textBoxTitle.Text;
            modifiedbook.Author = this.textBoxAuthor.Text;
            modifiedbook.Isbn = this.textBoxISBN.Text;
            modifiedbook.Edition.Day = Convert.ToInt32(this.textBoxEditionDay.Text);
            modifiedbook.Edition.Month = Convert.ToInt32(this.textBoxEditionMonth.Text);
            modifiedbook.Edition.Year = Convert.ToInt32(this.textBoxEditionYear.Text);

            this.listofBooks[index] = modifiedbook;
        }

        /////////////////// SEARCH button
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string search = this.textBoxSearch.Text;
            Book searchbook;
            bool found = false;
            this.listBoxBooks.Items.Clear();

            if (this.listofBooks.Count == 0)
            {
                MessageBox.Show("There is no data in the library inventory");
            }
            else
            {
                for (int idx = 0; idx < listofBooks.Count; idx++)
                {
                    searchbook = (Book) this.listofBooks[idx];
                    if ((searchbook.Id == search)||(searchbook.Title == search)||(searchbook.Author == search)|| (searchbook.Isbn == search))
                    {
                        this.listBoxBooks.Items.Add(this.listofBooks[idx]);
                        found = true;
                    }
                }
                if (!found) { MessageBox.Show("Found no data with the parameter entered"); }
            }
        }

        /////////////////// EXIT button
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<> GOOD BYE <>");
            this.Close();
        }

        /////////////////// SELECT BOOK ID
        private void ListBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxBooks.SelectedIndex;
            Book selectedbook = (Book) listofBooks[index];
            this.textBoxID.Text = selectedbook.Id;
            this.textBoxAuthor.Text = selectedbook.Author;
            this.textBoxTitle.Text = selectedbook.Title;
            this.textBoxISBN.Text = selectedbook.Isbn;
            this.textBoxEditionDay.Text = selectedbook.Edition.Day.ToString();
            this.textBoxEditionMonth.Text = selectedbook.Edition.Month.ToString();
            this.textBoxEditionYear.Text = selectedbook.Edition.Year.ToString();

            MessageBox.Show("You have selected the book ID: " + this.listofBooks[index]);
        }
    }
}
