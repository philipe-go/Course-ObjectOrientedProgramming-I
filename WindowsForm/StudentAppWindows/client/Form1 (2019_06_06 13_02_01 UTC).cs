using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentAppWindows.bus;

namespace StudentAppWindows
{
    public partial class Form1 : Form
    {
        public List<Student> studentList = new List<Student>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonADD_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(this.textBoxID.Text);
            aStudent.Firstname = this.textBoxFN.Text;
            aStudent.Lastname = this.textBoxLN.Text;

            Address anAddress = new Address();
            anAddress.Street = this.textBoxSt.Text;
            anAddress.City = this.textBoxCity.Text;
            anAddress.Province = this.textBoxProvince.Text;
            anAddress.Zip = this.textBoxZip.Text;

            aStudent.Addr = anAddress;

            Score aScore = new Score();
            aScore.Midterm = Convert.ToDouble(this.textBoxMterm.Text);
            aScore.Project = Convert.ToDouble(this.textBoxProject.Text);
            aScore.Finalterm = Convert.ToDouble(this.textBoxFinterm.Text);

            aStudent.Score = aScore;
            
            this.studentList.Add(aStudent);
            MessageBox.Show("< Student added >");
        }
  
        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e) //to review
        {
            index = listBoxStudent.SelectedIndex;
            MessageBox.Show("The selected index is: " + index);
        }

        private void buttonSHOW_Click_1(object sender, EventArgs e)
        {
            for (int index = 0; index < this.studentList.Count; index++)
            {
                this.listBoxStudent.Items.Add(this.studentList[index]);
            }
        }

        private void buttonCLEAR_Click_1(object sender, EventArgs e)
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    element.Text = "";
                }
            }
            this.listBoxStudent.Items.Clear();



            this.textBoxID.Focus();


        }

        private void buttonDELETE_Click_1(object sender, EventArgs e)
        {
            String message = "Do you want to remove the student frrom the list?";
            string caption = "Removing a Student";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.studentList.RemoveAt(index);
                MessageBox.Show("\n Student number  " + ++index + " removed ");
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("\n Student number  " + ++index + " NOT removed ");
            }
        }

        private void listBoxStudent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            index = this.listBoxStudent.SelectedIndex;
            this.textBoxID.Text = Convert.ToString(this.studentList[index].Id);
            this.textBoxFN.Text = this.studentList[index].Firstname;
            this.textBoxLN.Text = this.studentList[index].Lastname;


            this.textBoxSt.Text = this.studentList[index].Addr.Street;
            this.textBoxCity.Text = this.studentList[index].Addr.City;
            this.textBoxProvince.Text = this.studentList[index].Addr.Province;
            this.textBoxZip.Text = this.studentList[index].Addr.Zip;

            this.textBoxMterm.Text = Convert.ToString(this.studentList[index].Score.Midterm);
            this.textBoxProject.Text = Convert.ToString(this.studentList[index].Score.Project);
            this.textBoxFinalterm.Text = Convert.ToString(this.studentList[index].Score.FinalTerm);
            
        }

        private void buttonEXIT_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" <> GOOD BYE <> ");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
