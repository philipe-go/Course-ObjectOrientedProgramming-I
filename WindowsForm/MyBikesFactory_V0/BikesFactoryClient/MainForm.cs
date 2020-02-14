using BikesFactoryBusiness;
using BikesFactoryData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BikesFactoryClient
{
    public partial class MainForm : Form
    {
        List<Bikes> myListOfBikes = new List<Bikes>();
        int index = -1;

        public MainForm()
        {
            InitializeComponent();

            this.cbType.DataSource = Enum.GetValues(typeof(EnumBikeType));
            this.cbColor.DataSource = Enum.GetValues(typeof(EnumBikeColor));

            myListOfBikes = FileHandler.readXmlFile();

            DisplayListView();
        }

        /*****************Refresh Method***************/
        public void mRefresh()
        {
            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }

            this.tbMadeIn.Clear(); //loop above is not working with this TextBox???
            this.tbSearch.Clear(); //loop above is not working with this TextBox???

            this.cbType.SelectedItem = EnumBikeType.undefined;
            this.cbColor.SelectedItem = EnumBikeColor.undefined;
            this.dateManufacturer.Value = DateTime.Now;

            this.listViewBikes.Items.Clear();

            this.tbSerialNumber.Focus();
        }
        /*****************Display List Method***************/
        public void DisplayListView()
        {
            this.listViewBikes.Items.Clear();

            foreach (Bikes element in myListOfBikes)
            {
                ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                anItem.SubItems.Add(Convert.ToString(element.BikeType));
                anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                anItem.SubItems.Add(element.Manufacturer);
                anItem.SubItems.Add(element.MadeIn);
                anItem.SubItems.Add(element.ManufactureDate);
                anItem.SubItems.Add(Convert.ToString(element.Speed));

                listViewBikes.Items.Add(anItem);
            }
        }
       
        /*****************Selected Index***************/
        private void ListViewBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listViewBikes.FocusedItem.Index;

            this.tbSerialNumber.Text = Convert.ToString(myListOfBikes[index].SerialNumber);
            this.tbMadeIn.Text = Convert.ToString(myListOfBikes[index].MadeIn);
            this.tbManufacturer.Text = Convert.ToString(myListOfBikes[index].Manufacturer);
            this.cbType.SelectedItem = (EnumBikeType)myListOfBikes[index].BikeType;
            this.cbColor.SelectedItem = (EnumBikeColor)myListOfBikes[index].BikeColor;
            this.dateManufacturer.Value = Convert.ToDateTime(myListOfBikes[index].ManufactureDate);
        }

        /*****************EXIT BUTTON***************/
        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*****************ADD BUTTON***************/
        private void BtAdd_Click(object sender, EventArgs e)
        {
            if ((EnumBikeType)this.cbType.SelectedItem == EnumBikeType.Speed)
            {
                SpeedBikes aBike = new SpeedBikes();
                aBike.SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                aBike.Manufacturer = this.tbManufacturer.Text;
                aBike.MadeIn = this.tbMadeIn.Text;
                aBike.BikeType = (EnumBikeType)this.cbType.SelectedItem;
                aBike.BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                aBike.ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                this.myListOfBikes.Add(aBike);

                mRefresh();
                DisplayListView();
            }
            else if ((EnumBikeType)this.cbType.SelectedItem == EnumBikeType.Road)
            {
                RoadBikes aBike = new RoadBikes();
                aBike.SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                aBike.Manufacturer = this.tbManufacturer.Text;
                aBike.MadeIn = this.tbMadeIn.Text;
                aBike.BikeType = (EnumBikeType)this.cbType.SelectedItem;
                aBike.BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                aBike.ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                this.myListOfBikes.Add(aBike);

                mRefresh();
                DisplayListView();
            }
            else if ((EnumBikeType)this.cbType.SelectedItem == EnumBikeType.Mountain)
            {
                MountainBikes aBike = new MountainBikes();
                aBike.SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                aBike.Manufacturer = this.tbManufacturer.Text;
                aBike.MadeIn = this.tbMadeIn.Text;
                aBike.BikeType = (EnumBikeType)this.cbType.SelectedItem;
                aBike.BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                aBike.ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                this.myListOfBikes.Add(aBike);

                mRefresh();
                DisplayListView();
            }
            else if ((EnumBikeType)this.cbType.SelectedItem == EnumBikeType.Motor)
            {
                MotorBikes aBike = new MotorBikes();
                aBike.SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                aBike.Manufacturer = this.tbManufacturer.Text;
                aBike.MadeIn = this.tbMadeIn.Text;
                aBike.BikeType = (EnumBikeType)this.cbType.SelectedItem;
                aBike.BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                aBike.ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                this.myListOfBikes.Add(aBike);

                mRefresh();
                DisplayListView();
            }
            else if ((EnumBikeType)this.cbType.SelectedItem == EnumBikeType.BMX)
            {
                BMXBikes aBike = new BMXBikes();
                aBike.SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                aBike.Manufacturer = this.tbManufacturer.Text;
                aBike.MadeIn = this.tbMadeIn.Text;
                aBike.BikeType = (EnumBikeType)this.cbType.SelectedItem;
                aBike.BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                aBike.ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                this.myListOfBikes.Add(aBike);

                mRefresh();
                DisplayListView();
            }
        }
        /*****************REMOVE BUTTON***************/
        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                this.myListOfBikes.RemoveAt(index);

                this.listViewBikes.Items.Clear();

                DisplayListView();

                index = -1;

            }
            else { MessageBox.Show("No Index Selected"); }
        }
        /*****************UPDATE BUTTON***************/
        private void BtUpdate_Click(object sender, EventArgs e)
        {
            //#############Check Changing Bike Type Bug
            if (index != -1)
            {
                myListOfBikes[index].SerialNumber = Convert.ToInt32(this.tbSerialNumber.Text);
                myListOfBikes[index].MadeIn = this.tbMadeIn.Text;
                myListOfBikes[index].Manufacturer = this.tbManufacturer.Text;
                myListOfBikes[index].BikeType = (EnumBikeType)this.cbType.SelectedItem;
                myListOfBikes[index].BikeColor = (EnumBikeColor)this.cbColor.SelectedItem;
                myListOfBikes[index].ManufactureDate = Convert.ToString(this.dateManufacturer.Value);

                mRefresh();

                DisplayListView();
            }
        }
        /*****************REFRESH BUTTON***************/
        private void BtRefresh_Click(object sender, EventArgs e)
        {
            mRefresh();
            index = -1;
        }
        /*****************SAVE BUTTON***************/
        private void BtSave_Click(object sender, EventArgs e)
        {
            FileHandler.writeXmlFile(myListOfBikes);
            MessageBox.Show("Saved");
        }
        /*****************LOAD BUTTON***************/
        private void BtLoad_Click(object sender, EventArgs e)
        {
            myListOfBikes = FileHandler.readXmlFile();

            DisplayListView();
        }

        /*****************DISPLAY All BUTTON***************/
        private void BtDisplayAll_Click(object sender, EventArgs e)
        {
            mRefresh();
            DisplayListView();
        }
        /*****************DISPLAY MouBike BUTTON***************/
        private void BtDisplayMountB_Click(object sender, EventArgs e)
        {
            mRefresh();

            foreach (Bikes element in myListOfBikes)
            {
                if (element.GetType() == typeof(MountainBikes))
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                    anItem.SubItems.Add(Convert.ToString(element.BikeType));
                    anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                    anItem.SubItems.Add(element.Manufacturer);
                    anItem.SubItems.Add(element.MadeIn);
                    anItem.SubItems.Add(element.ManufactureDate);
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(0));

                    listViewBikes.Items.Add(anItem);
                }
            }

            this.tbSerialNumber.Focus();
        }
        /*****************DISPLAY RoaBike BUTTON***************/
        private void BtDisplayRB_Click(object sender, EventArgs e)
        {
            mRefresh();

            foreach (Bikes element in myListOfBikes)
            {
                if (element.GetType() == typeof(RoadBikes))
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                    anItem.SubItems.Add(Convert.ToString(element.BikeType));
                    anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                    anItem.SubItems.Add(element.Manufacturer);
                    anItem.SubItems.Add(element.MadeIn);
                    anItem.SubItems.Add(element.ManufactureDate);
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(0));

                    listViewBikes.Items.Add(anItem);
                }
            }

            this.tbSerialNumber.Focus();
        }
        /*****************DISPLAY SpeBike BUTTON***************/
        private void BtDisplaySB_Click(object sender, EventArgs e)
        {
            mRefresh();

            foreach (Bikes element in myListOfBikes)
            {
                if (element.GetType() == typeof(SpeedBikes))
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                    anItem.SubItems.Add(Convert.ToString(element.BikeType));
                    anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                    anItem.SubItems.Add(element.Manufacturer);
                    anItem.SubItems.Add(element.MadeIn);
                    anItem.SubItems.Add(element.ManufactureDate);
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(0));

                    listViewBikes.Items.Add(anItem);
                }
            }

            this.tbSerialNumber.Focus();
        }
        /*****************DISPLAY MotBike BUTTON***************/
        private void BtDisplayMotorB_Click(object sender, EventArgs e)
        {
            mRefresh();

            foreach (Bikes element in myListOfBikes)
            {
                if (element.GetType() == typeof(MotorBikes))
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                    anItem.SubItems.Add(Convert.ToString(element.BikeType));
                    anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                    anItem.SubItems.Add(element.Manufacturer);
                    anItem.SubItems.Add(element.MadeIn);
                    anItem.SubItems.Add(element.ManufactureDate);
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(0));

                    listViewBikes.Items.Add(anItem);
                }
            }

            this.tbSerialNumber.Focus();
        }
        /*****************DISPLAY Bmx BUTTON***************/
        private void BtBMX_Click(object sender, EventArgs e)
        {
            mRefresh();

            foreach (Bikes element in myListOfBikes)
            {
                if (element.GetType() == typeof(BMXBikes))
                {
                    ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                    anItem.SubItems.Add(Convert.ToString(element.BikeType));
                    anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                    anItem.SubItems.Add(element.Manufacturer);
                    anItem.SubItems.Add(element.MadeIn);
                    anItem.SubItems.Add(element.ManufactureDate);
                    anItem.SubItems.Add(Convert.ToString(element.Speed));
                    anItem.SubItems.Add(Convert.ToString(0));

                    listViewBikes.Items.Add(anItem);
                }
            }

            this.tbSerialNumber.Focus();
        }
        /*****************FILTER BUTTON***************/
        private void BtFilter_Click(object sender, EventArgs e)
        {
            if (myListOfBikes.Count != 0)
            {
                this.listViewBikes.Items.Clear();
                bool found = false;
                foreach (Bikes element in myListOfBikes)
                {
                    if ( (this.tbSearch.Text == Convert.ToString(element.SerialNumber)) || (this.tbSearch.Text == Convert.ToString(element.BikeType)) || (this.tbSearch.Text == Convert.ToString(element.BikeColor))
                        || (this.tbSearch.Text == element.Manufacturer) || (this.tbSearch.Text == element.MadeIn) || (this.tbSearch.Text == Convert.ToString(element.ManufactureDate)) )
                    {
                        ListViewItem anItem = new ListViewItem(Convert.ToString(element.SerialNumber));
                        anItem.SubItems.Add(Convert.ToString(element.BikeType));
                        anItem.SubItems.Add(Convert.ToString(element.BikeColor));
                        anItem.SubItems.Add(element.Manufacturer);
                        anItem.SubItems.Add(element.MadeIn);
                        anItem.SubItems.Add(element.ManufactureDate);
                        anItem.SubItems.Add(Convert.ToString(element.Speed));
                        anItem.SubItems.Add(Convert.ToString(0));

                        listViewBikes.Items.Add(anItem);

                        found = true;
                    }
                }
                if(!found)
                {
                    MessageBox.Show("There is no item on the Data Base with inputed parameter\nRemember the case sensitivity of the software");
                }
                this.tbSearch.Clear();
                this.tbSerialNumber.Focus();
            }

            this.tbSerialNumber.Focus();
        }

        /*****************MOVE BUTTON***************/
        private void BtMove_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                myListOfBikes[index].Speed = myListOfBikes[index].move();
                DisplayListView();
            }
            else { MessageBox.Show("Select and item"); }
        }
        /*****************STOP BUTTON***************/
        private void BtStop_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                myListOfBikes[index].Speed = myListOfBikes[index].stop();
                DisplayListView();
            }
            else { MessageBox.Show("Select and item"); }
        }
        /*****************ENGINE BUTTON***************/
        private void BtEngine_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                if (myListOfBikes[index].GetType() == typeof(MotorBikes))
                {
                    MotorBikes aBike = new MotorBikes();
                    aBike.SerialNumber = myListOfBikes[index].SerialNumber;
                    aBike.Manufacturer = myListOfBikes[index].Manufacturer;
                    aBike.MadeIn = myListOfBikes[index].MadeIn;
                    aBike.BikeColor = myListOfBikes[index].BikeColor;
                    aBike.BikeType = myListOfBikes[index].BikeType;
                    aBike.ManufactureDate = myListOfBikes[index].ManufactureDate;
                    aBike.startEngine();
                    myListOfBikes[index] = aBike;

                    MessageBox.Show("Engine Started");
                }
                else { MessageBox.Show("This bike does not have an engine"); }
            }
            else { MessageBox.Show("Select and item"); }
        }
        /*****************JUMP BUTTON***************/
        private void BtJump_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                if (myListOfBikes[index].GetType() == typeof(BMXBikes))
                {
                    ((BMXBikes)myListOfBikes[index]).jump();
                    MessageBox.Show("Bike Jumps");
                    DisplayListView();
                }
                else if (myListOfBikes[index].GetType() == typeof(MountainBikes))
                {
                    if (((MountainBikes)myListOfBikes[index]).Suspension)
                    {
                        MessageBox.Show("Bike Jumps");
                        ((MountainBikes)myListOfBikes[index]).jump();
                    }
                    else
                    {
                        MessageBox.Show("The Bike is without suspension. Install a new one.");
                    }

                    DisplayListView();
                }
                else { MessageBox.Show("This bike can not jump due to the suspension and/or weight"); }
            }
            else { MessageBox.Show("Select and item"); }
        }
        /*****************SUSPENSION BUTTON***************/
        private void BtSuspension_Click(object sender, EventArgs e)
        {
            if (myListOfBikes[index].GetType() == typeof(MountainBikes))
            {
                MountainBikes aBike = new MountainBikes();
                aBike.SerialNumber = myListOfBikes[index].SerialNumber;
                aBike.Manufacturer = myListOfBikes[index].Manufacturer;
                aBike.MadeIn = myListOfBikes[index].MadeIn;
                aBike.BikeColor = myListOfBikes[index].BikeColor;
                aBike.BikeType = myListOfBikes[index].BikeType;
                aBike.ManufactureDate = myListOfBikes[index].ManufactureDate;
                aBike.installSuspension();
                myListOfBikes[index] = aBike;

                MessageBox.Show("New Suspension Installed");
                DisplayListView();
            }
            else { MessageBox.Show("This bike does not use suspension"); }
        }

        //Validators Action
        #region ##Validators##
        private void TbSerialNumber_TextChanged(object sender, EventArgs e)
        {
            if(!Validator.isDigit(this.tbSerialNumber.Text))
            {
                this.tbSerialNumber.Text = "";
                this.tbSerialNumber.Focus();
                MessageBox.Show("The Serial Number is a set of number with a maximum of 10 characters");
            }
        }

        private void TbManufacturer_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isChar(this.tbManufacturer.Text))
            {
                this.tbManufacturer.Text = "";
                this.tbManufacturer.Focus();
            }
        }

        private void TbMadeIn_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isChar(this.tbMadeIn.Text))
            {
                this.tbMadeIn.Text = "";
                this.tbMadeIn.Focus();
            }
        }
        #endregion

    }
}
