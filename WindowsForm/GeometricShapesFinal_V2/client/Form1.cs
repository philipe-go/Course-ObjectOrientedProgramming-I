using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShapesDataLayer.business;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace GeometricShapesFinal
{
    public partial class Form1 : Form
    {
        List<Shapes> myListOfShapes = new List<Shapes>();
        int index = 0;

        public Form1()
        {
            InitializeComponent();

            this.cbBrColor.DataSource = Enum.GetValues(typeof(EnumBrushingColor));
            this.cbBoColor.DataSource = Enum.GetValues(typeof(EnumBorderColor));
            this.tbXCoord.Focus();
        }

        //Refresh Method
        public void mRefresh()
        {
            foreach(Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }

            this.listBoxShapes.Items.Clear();

            this.tbDx.Text = "5";
            this.tbDy.Text = "5";

            this.index = -1;

            this.panel1.Refresh();
        }

        //Select Index
        private void ListBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBoxShapes.SelectedIndex;
            this.panel1.Refresh();
        }
       
        //Drawing Panel
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if ((myListOfShapes.Count()!= 0)&&(index>=0))
            {
                myListOfShapes[index].Draw(e);
            }
        }
        
        //Text Box Validation
        #region
        private void TbXCoord_TextChanged(object sender, EventArgs e)
        {
            if(!Validator.isDigit(this.tbXCoord.Text))
            {
                this.tbXCoord.Clear();
                this.tbXCoord.Focus();
            }
        }

        private void TbYCoord_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isDigit(this.tbYCoord.Text))
            {
                this.tbYCoord.Clear();
                this.tbYCoord.Focus();
            }
        }

        private void TbSide_TextChanged(object sender, EventArgs e)
        {
            this.rbSquare.Checked = true;
            this.rbRectangle.Checked = false;
            this.rbCircle.Checked = false;
            this.rbEllipse.Checked = false;

            this.tbHeight.Text = "";
            this.tbLength.Text = "";
            this.tbRadius.Text = "";
            this.tbXRadius.Text = "";
            this.tbYRadius.Text = "";

            if (!Validator.isDecimal(this.tbSide.Text))
            {
                this.tbSide.Clear();
                this.tbSide.Focus();
            }
        }

        private void TbHeight_TextChanged(object sender, EventArgs e)
        {
            this.rbRectangle.Checked = true;
            this.rbSquare.Checked = false;
            this.rbCircle.Checked = false;
            this.rbEllipse.Checked = false;

            this.tbSide.Text = "";
            this.tbRadius.Text = "";
            this.tbXRadius.Text = "";
            this.tbYRadius.Text = "";

            if (!Validator.isDecimal(this.tbHeight.Text))
            {
                this.tbHeight.Clear();
                this.tbHeight.Focus();
            }
        }

        private void TbLength_TextChanged(object sender, EventArgs e)
        {
            this.rbRectangle.Checked = true;
            this.rbSquare.Checked = false;
            this.rbCircle.Checked = false;
            this.rbEllipse.Checked = false;

            this.tbSide.Text = "";
            this.tbRadius.Text = "";
            this.tbXRadius.Text = "";
            this.tbYRadius.Text = "";

            if (!Validator.isDecimal(this.tbLength.Text))
            {
                this.tbLength.Clear();
                this.tbLength.Focus();
            }
        }

        private void TbRadius_TextChanged(object sender, EventArgs e)
        {
            this.rbCircle.Checked = true;
            this.rbRectangle.Checked = false;
            this.rbSquare.Checked = false;
            this.rbEllipse.Checked = false;

            this.tbSide.Text = "";
            this.tbHeight.Text = "";
            this.tbLength.Text = "";
            this.tbXRadius.Text = "";
            this.tbYRadius.Text = "";

            if (!Validator.isDecimal(this.tbRadius.Text))
            {
                this.tbRadius.Clear();
                this.tbRadius.Focus();
            }
        }

        private void TbXRadius_TextChanged(object sender, EventArgs e)
        {
            this.rbEllipse.Checked = true;
            this.rbRectangle.Checked = false;
            this.rbCircle.Checked = false;
            this.rbSquare.Checked = false;

            this.tbSide.Text = "";
            this.tbHeight.Text = "";
            this.tbLength.Text = "";
            this.tbRadius.Text = "";

            if (!Validator.isDecimal(this.tbXRadius.Text))
            {
                this.tbXRadius.Clear();
                this.tbXRadius.Focus();
            }
        }

        private void TbYRadius_TextChanged(object sender, EventArgs e)
        {
            this.rbEllipse.Checked = true;
            this.rbRectangle.Checked = false;
            this.rbCircle.Checked = false;
            this.rbSquare.Checked = false;

            this.tbSide.Text = "";
            this.tbHeight.Text = "";
            this.tbLength.Text = "";
            this.tbRadius.Text = "";

            if (!Validator.isDecimal(this.tbYRadius.Text))
            {
                this.tbYRadius.Clear();
                this.tbYRadius.Focus();
            }
        }

        private void TbDy_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isDigit(this.tbDy.Text))
            {
                this.tbDy.Clear();
                this.tbDy.Focus();
            }
        }

        private void TbDx_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isDigit(this.tbDx.Text))
            {
                this.tbDx.Clear();
                this.tbDx.Focus();
            }
        }
        #endregion

        //DRAW BUTTON
        private void BtDraw_Click(object sender, EventArgs e)
        {
            //SQUARE
            if(rbSquare.Checked==true)
            {
                Squares aShape = new Squares();
                aShape.ShapeType = EnumShapeType.Square;
                aShape.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                aShape.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                aShape.Side = Convert.ToDouble(this.tbSide.Text);
                aShape.BrushColor = (EnumBrushingColor)this.cbBrColor.SelectedItem;
                aShape.BorderColor = (EnumBorderColor)this.cbBoColor.SelectedItem;

                this.myListOfShapes.Add(aShape);

                index = myListOfShapes.LastIndexOf(aShape);

                this.panel1.Refresh();

                this.listBoxShapes.Items.Clear();

                foreach(Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }

                this.btUp.Focus();
            }
            //RECTANGLE
            else if (rbRectangle.Checked == true)
            {
                Rectangles aShape = new Rectangles();
                aShape.ShapeType = EnumShapeType.Rectangle;
                aShape.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                aShape.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                aShape.Height = Convert.ToDouble(this.tbHeight.Text);
                aShape.Length = Convert.ToDouble(this.tbLength.Text);
                aShape.BrushColor = (EnumBrushingColor)this.cbBrColor.SelectedItem;
                aShape.BorderColor = (EnumBorderColor)this.cbBoColor.SelectedItem;

                this.myListOfShapes.Add(aShape);

                index = myListOfShapes.LastIndexOf(aShape);

                this.panel1.Refresh();

                this.listBoxShapes.Items.Clear();

                foreach (Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }

                this.btUp.Focus();
            }
            //CIRCLE
            else if (rbCircle.Checked == true)
            {
                Circles aShape = new Circles();
                aShape.ShapeType = EnumShapeType.Circle;
                aShape.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                aShape.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                aShape.Radius = Convert.ToDouble(this.tbRadius.Text);
                aShape.BrushColor = (EnumBrushingColor)this.cbBrColor.SelectedItem;
                aShape.BorderColor = (EnumBorderColor)this.cbBoColor.SelectedItem;

                this.myListOfShapes.Add(aShape);

                index = myListOfShapes.LastIndexOf(aShape);

                this.panel1.Refresh();

                this.listBoxShapes.Items.Clear();

                foreach (Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }

                this.btUp.Focus();
            }
            //ELIPSES
            else if (rbEllipse.Checked == true)
            {
                Ellipses aShape = new Ellipses();
                aShape.ShapeType = EnumShapeType.Ellipse;
                aShape.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                aShape.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                aShape.XRadius = Convert.ToDouble(this.tbXRadius.Text);
                aShape.YRadius = Convert.ToDouble(this.tbYRadius.Text);
                aShape.BrushColor = (EnumBrushingColor)this.cbBrColor.SelectedItem;
                aShape.BorderColor = (EnumBorderColor)this.cbBoColor.SelectedItem;

                this.myListOfShapes.Add(aShape);

                index = myListOfShapes.LastIndexOf(aShape);

                this.panel1.Refresh();

                this.listBoxShapes.Items.Clear();

                foreach (Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }

                this.btUp.Focus();
            }
        }

        //MOVE BUTTONS
        #region ##Shape Moving##
        private void MoveRefresh()
        {
            this.panel1.Refresh();
            this.listBoxShapes.Items.Clear();
            foreach (Shapes element in myListOfShapes)
            {
                this.listBoxShapes.Items.Add(element);
            }
        }
        private void BtUp_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveUp(Convert.ToInt32(this.tbDy.Text));
            MoveRefresh();
        }
        private void BtDown_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveDown(Convert.ToInt32(this.tbDy.Text));
            MoveRefresh();
        }
        private void BtLeft_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveLeft(Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        private void BtRight_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveRight(Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        private void BtUpRight_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveUpRight(Convert.ToInt32(this.tbDy.Text), Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        private void BtUpLeft_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveUpLeft(Convert.ToInt32(this.tbDy.Text), Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        private void BtDownRight_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveDownRight(Convert.ToInt32(this.tbDy.Text), Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        private void BtDownLeft_Click(object sender, EventArgs e)
        {
            myListOfShapes[index].moveDownLeft(Convert.ToInt32(this.tbDy.Text), Convert.ToInt32(this.tbDx.Text));
            MoveRefresh();
        }
        #endregion //MOVE BUTTONS

        //CLOSE BUTTON
        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SAVE BUTTON
        private void BtSave_Click(object sender, EventArgs e)
        {
                FileHandler.writeToXML(this.myListOfShapes);
        }

        //LOAD BUTTON
        private void BtLoad_Click(object sender, EventArgs e)
        {
                this.listBoxShapes.Items.Clear();
                this.myListOfShapes.Clear();

                this.myListOfShapes = FileHandler.readFromXML();

                foreach (Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }

                this.tbXCoord.Focus();

        }

        //REFRESH BUTTON
        private void BtRefresh_Click(object sender, EventArgs e)
        {
            mRefresh();
        }

        //DELETE BUTTON
        private void BtDelete_Click(object sender, EventArgs e)
        {
            myListOfShapes.RemoveAt(index);
            mRefresh();

            if (myListOfShapes.Count() != 0)
            {
                foreach (Shapes element in myListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }
            }
        }
    }
}
