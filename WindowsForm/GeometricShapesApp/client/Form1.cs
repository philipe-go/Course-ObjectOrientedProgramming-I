//project done by Philipe Gouveia @ July 8th, 2019
//assignment requested on Summer Session Lasalle College - Object Oriented Programming

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapesApp.business;
using GeometricShapesApp.data;

namespace GeometricShapesApp
{
    public partial class Form1 : Form
    {
        List<Shapes> listOfShapes = new List<Shapes>();
        public int index = -1;
        public int aSerial;
        public bool selection = false;

        public Form1()
        {
            InitializeComponent();

            this.cBName.DataSource = Enum.GetValues(typeof(ShapeName));
            this.cBName.SelectedItem = ShapeName.Type;

            this.cBColor.DataSource = Enum.GetValues(typeof(ShapeColor));
            this.cBColor.SelectedItem = ShapeColor.Color;
        }


        /**********************REFRESH METHOD****************/
        private void mRefresh()
        {
            this.listBoxShapes.Items.Clear();
            this.tBXcoor.Clear();
            this.tBYcoor.Clear();
            this.tBBaseRadius.Clear();
            this.tBHeight.Clear();
            this.labelMove.Visible = false;
            this.labelHeight.Visible = false;
            this.labelBaseRadius.Visible = false;
            this.tBBaseRadius.Visible = false;
            this.tBHeight.Visible = false;
            this.buttonAdd2.Visible = false;
            this.ArrowDown.Visible = false;
            this.ArrowLeft.Visible = false;
            this.ArrowUp.Visible = false;
            this.ArrowRight.Visible = false;
            this.ArrowLeftUp.Visible = false;
            this.ArrowLeftDown.Visible = false;
            this.ArrowRightUp.Visible = false;
            this.ArrowRightDown.Visible = false;
            this.tBIncrement.Visible = false;
            this.labelIncr.Visible = false;
            selection = false;
            this.panelDrawing.Refresh();
        }

        /**********************List Box**********************/
        private void ListBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = this.listBoxShapes.SelectedIndex;
            MessageBox.Show($"Selected item index {index} from the list");
            //mRefresh();

            //this.listBoxShapes.Items.Add(listOfShapes[index]);
            selection = true;
        }

        /**********************CREATE Button**********************/
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if ((ShapeName)this.cBName.SelectedItem == ShapeName.triangle)
            {
                MessageBox.Show("Enter the new informations");
                this.tBBaseRadius.Visible = true;
                this.tBHeight.Visible = true;
                this.tBBaseRadius.Focus();
                this.buttonAdd2.Visible = true;
                this.labelHeight.Visible = true;
                this.labelBaseRadius.Visible = true;

            }
            else if ((ShapeName)this.cBName.SelectedItem == ShapeName.circle)
            {
                MessageBox.Show("Enter the new informations");
                this.tBBaseRadius.Visible = true;
                this.tBBaseRadius.Focus();
                this.buttonAdd2.Visible = true;
                this.labelBaseRadius.Text = "Circle Radius";
                this.labelBaseRadius.Visible = true;
            }
            else if ((ShapeName)this.cBName.SelectedItem == ShapeName.rectangle)
            {
                MessageBox.Show("Enter the new informations");
                this.tBBaseRadius.Visible = true;
                this.tBBaseRadius.Focus();
                this.tBHeight.Visible = true;
                this.buttonAdd2.Visible = true; ;
                this.labelHeight.Visible = true;
                this.labelBaseRadius.Visible = true;
            }
            else if (this.cBName.Text == Convert.ToString(ShapeName.square))
            {
                MessageBox.Show("Enter the new informations");
                this.tBBaseRadius.Visible = true;
                this.tBBaseRadius.Focus();
                this.buttonAdd2.Visible = true;
                this.labelBaseRadius.Visible = true;
                this.labelBaseRadius.Text = "Square Side";
            }
        }

        /**********************ADD Button**********************/
        private void ButtonAdd2_Click(object sender, EventArgs e)
        {
            if (listOfShapes.Count() == 0) { aSerial = 0001; }
            else { aSerial++; }

            if ((ShapeName)this.cBName.SelectedItem == ShapeName.triangle)
            {
                Triangle aShape = new Triangle();
                aShape.SerialNumber = aSerial;
                aShape.Name = (ShapeName)this.cBName.SelectedItem;
                cBName.SelectedItem = ShapeName.Type;
                aShape.Color = (ShapeColor)this.cBColor.SelectedItem;
                cBColor.SelectedItem = ShapeColor.Color;
                aShape.XCoordinate = Convert.ToInt32(tBXcoor.Text);
                aShape.YCoordinate = Convert.ToInt32(tBYcoor.Text);
                aShape.TriangBase = Convert.ToInt32(tBBaseRadius.Text);
                aShape.TriangHeight = Convert.ToInt32(tBHeight.Text);

                mRefresh();

                this.listOfShapes.Add(aShape);
            }
            else if ((ShapeName)this.cBName.SelectedItem == ShapeName.circle)
            {
                Circle aShape = new Circle();
                aShape.SerialNumber = aSerial;
                aShape.Name = (ShapeName)this.cBName.SelectedItem;
                cBName.SelectedItem = ShapeName.Type;
                aShape.Color = (ShapeColor)this.cBColor.SelectedItem;
                cBColor.SelectedItem = ShapeColor.Color;
                aShape.XCoordinate = Convert.ToInt32(tBXcoor.Text);
                aShape.YCoordinate = Convert.ToInt32(tBYcoor.Text);
                aShape.Radius = Convert.ToInt32(tBBaseRadius.Text);

                this.labelBaseRadius.Text = "Poligon Base";

                mRefresh();

                this.listOfShapes.Add(aShape);
            }
            else if ((ShapeName)this.cBName.SelectedItem == ShapeName.rectangle)
            {
                Rectangles aShape = new Rectangles();
                aShape.SerialNumber = aSerial;
                aShape.Name = (ShapeName)this.cBName.SelectedItem;
                cBName.SelectedItem = ShapeName.Type;
                aShape.Color = (ShapeColor)this.cBColor.SelectedItem;
                cBColor.SelectedItem = ShapeColor.Color;
                aShape.XCoordinate = Convert.ToInt32(tBXcoor.Text);
                aShape.YCoordinate = Convert.ToInt32(tBYcoor.Text);
                aShape.PoligonBase = Convert.ToInt32(tBBaseRadius.Text);
                aShape.PoligonHeight = Convert.ToInt32(tBHeight.Text);

                if (aShape.PoligonBase == aShape.PoligonHeight)
                {
                    MessageBox.Show("As the Base and Height are equal the shape type was changed to square");
                    Square aShapeChange = new Square();
                    aShapeChange.Name = ShapeName.square;
                    aShapeChange.Color = aShape.Color;
                    aShapeChange.XCoordinate = aShape.XCoordinate;
                    aShapeChange.YCoordinate = aShape.YCoordinate;
                    aShapeChange.PoligonBase = aShape.PoligonBase;

                    this.listOfShapes.Add(aShapeChange);
                }
                else { this.listOfShapes.Add(aShape); }

                mRefresh();
            }
            else if ((ShapeName)this.cBName.SelectedItem == ShapeName.square)
            {
                Square aShape = new Square();
                aShape.SerialNumber = aSerial;
                aShape.Name = (ShapeName)this.cBName.SelectedItem;
                cBName.SelectedItem = ShapeName.Type;
                aShape.Color = (ShapeColor)this.cBColor.SelectedItem;
                cBColor.SelectedItem = ShapeColor.Color;
                aShape.XCoordinate = Convert.ToInt32(tBXcoor.Text);
                aShape.YCoordinate = Convert.ToInt32(tBYcoor.Text);
                aShape.PoligonBase = Convert.ToInt32(tBBaseRadius.Text);

                mRefresh();

                this.labelBaseRadius.Text = "Poligon Base";

                this.listOfShapes.Add(aShape);
            }

            this.cBName.Focus();
            this.listBoxShapes.Items.Clear();

            if (listOfShapes.Count() != 0)
            {
                foreach (Shapes element in listOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }
            }
        }

        /**********************REMOVE Button**********************/
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listOfShapes.Count == 0)
            {
                MessageBox.Show("Impossible to remove - No items selected");
            }
            else
            {
                this.listOfShapes.RemoveAt(index);
                MessageBox.Show($"Removed item from index {index} of the list");

                this.listBoxShapes.Items.Clear();
                if (listOfShapes.Count() != 0)
                {
                    foreach (Shapes element in listOfShapes)
                    {
                        this.listBoxShapes.Items.Add(element);
                    }
                }
            }
        }

        /**********************EXIT Button**********************/
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************DISPLAY Button**********************/
        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            this.listBoxShapes.Items.Clear();

            foreach (Shapes element in listOfShapes)
            {
                this.listBoxShapes.Items.Add(element);
            }

            this.cBName.Focus();
        }

        /**********************SEARCH Button**********************/
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string search = this.tBSearch.Text;
            this.listBoxShapes.Items.Clear();
            bool found = false;

            foreach (Shapes element in listOfShapes)
            {
                if ((search == Convert.ToString(element.Name)) || (search == Convert.ToString(element.Color)))
                {
                    this.listBoxShapes.Items.Add(element);
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show($"No items found in the list with specified searched data");
            }
        }

        /**********************REFRESH Button**********************/
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            mRefresh();
        }

        /**********************MOVE Button**********************/
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (listOfShapes.Count == 0)
            {
                MessageBox.Show("Impossible to move - No items selected or list of items empty");
            }
            else
            {
                if (!this.labelMove.Visible)
                {
                    this.listBoxShapes.Items.Clear();
                    this.listBoxShapes.Items.Add(listOfShapes[index]);
                    this.labelMove.Visible = true;
                    this.ArrowDown.Visible = true;
                    this.ArrowLeft.Visible = true;
                    this.ArrowUp.Visible = true;
                    this.ArrowRight.Visible = true;
                    this.ArrowLeftUp.Visible = true;
                    this.ArrowLeftDown.Visible = true;
                    this.ArrowRightUp.Visible = true;
                    this.ArrowRightDown.Visible = true;
                    this.tBIncrement.Visible = true;
                    this.labelIncr.Visible = true;
                }
                else
                {
                    this.labelMove.Visible = false;
                    this.ArrowDown.Visible = false;
                    this.ArrowLeft.Visible = false;
                    this.ArrowUp.Visible = false;
                    this.ArrowRight.Visible = false;
                    this.ArrowLeftUp.Visible = false;
                    this.ArrowLeftDown.Visible = false;
                    this.ArrowRightUp.Visible = false;
                    this.ArrowRightDown.Visible = false;
                    this.tBIncrement.Visible = false;
                    this.labelIncr.Visible = false;
                }

                this.tBIncrement.Focus();
            }
        }

        /**********************DRAWING PANEL**********************/
        private void PanelDrawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 2);
            Brush myBrush = new SolidBrush(Color.Gray);

            if (selection)
            {
                if (listOfShapes[index].GetType() == typeof(Rectangles))
                {
                    Rectangles aRectangle = (Rectangles)listOfShapes[index];
                    g.DrawRectangle(myPen, aRectangle.XCoordinate, aRectangle.YCoordinate, aRectangle.PoligonBase, aRectangle.PoligonHeight);
                    g.FillRectangle(myBrush, aRectangle.XCoordinate, aRectangle.YCoordinate, aRectangle.PoligonBase, aRectangle.PoligonHeight);
                    myPen.Dispose();
                    myBrush.Dispose();
                    e.Graphics.Dispose();
                }
                else if (listOfShapes[index].GetType() == typeof(Square))
                {
                    Square aSquare = (Square)listOfShapes[index];
                    g.DrawRectangle(myPen, aSquare.XCoordinate, aSquare.YCoordinate, aSquare.PoligonBase, aSquare.PoligonBase);
                    g.FillRectangle(myBrush, aSquare.XCoordinate, aSquare.YCoordinate, aSquare.PoligonBase, aSquare.PoligonBase);
                    myPen.Dispose();
                    myBrush.Dispose();
                    e.Graphics.Dispose();
                }
                else if (listOfShapes[index].GetType() == typeof(Circle))
                {
                    Circle aEllipse = (Circle)listOfShapes[index];
                    g.DrawEllipse(myPen, aEllipse.XCoordinate, aEllipse.YCoordinate, aEllipse.Radius, aEllipse.Radius);
                    g.FillEllipse(myBrush, aEllipse.XCoordinate, aEllipse.YCoordinate, aEllipse.Radius, aEllipse.Radius);
                    myPen.Dispose();
                    myBrush.Dispose();
                    e.Graphics.Dispose();
                }
                else if (listOfShapes[index].GetType() == typeof(Triangle))
                {
                    MessageBox.Show("Not possible to draw triangles");
                }
            }
        }

        /**********************DRAW Button**********************/
        private void BtDraw_Click(object sender, EventArgs e)
        {
            if (selection)
            {
                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
            }
            else
            {
                MessageBox.Show("You did not select any shape to be drawn");
            }
        }

        /**********************SAVE Button**********************/
        private void BtSave_Click(object sender, EventArgs e)
        {
            FileHandler.writeToBinFile(this.listOfShapes);
        }

        /**********************LOAD Button**********************/
        private void BtLoad_Click(object sender, EventArgs e)
        {
            mRefresh();
            this.listOfShapes = FileHandler.ReadFromBinFile();

            foreach(Shapes element in listOfShapes)
            {
                this.listBoxShapes.Items.Add(element);
            }
        }

        #region //Arrows Commands
        void ArrowLeftUp_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveDownLeft(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowUp_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            if ((aShape.XCoordinate > 0) && (aShape.YCoordinate > 0))
            {
                aShape.moveDown(Convert.ToInt32(this.tBIncrement.Text));
                this.listBoxShapes.Items.Clear();
                this.listBoxShapes.Items.Add(aShape);
                this.panelDrawing.Invalidate();
                this.panelDrawing.Update();
            }
        }

        void ArrowRightUp_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveDownRight(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowRight_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveRight(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowRightDown_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveUpRight(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowDown_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveUp(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowLeftDown_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveUpLeft(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }

        void ArrowLeft_Click(object sender, EventArgs e)
        {
            Shapes aShape = this.listOfShapes[index];
            aShape.moveLeft(Convert.ToInt32(this.tBIncrement.Text));
            this.listBoxShapes.Items.Clear();
            this.listBoxShapes.Items.Add(aShape);
            this.panelDrawing.Invalidate();
            this.panelDrawing.Update();
        }
        #endregion

        private void TBXcoor_TextChanged(object sender, EventArgs e)
        {
            if (!Validator.isDigit(this.TBXcoor.Text))
            {

            }
        }
    }
}
