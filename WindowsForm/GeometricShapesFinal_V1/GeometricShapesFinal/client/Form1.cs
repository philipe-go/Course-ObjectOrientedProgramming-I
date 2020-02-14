using System;
using System.Drawing;
using System.Windows.Forms;
using GeometricShapesFinal;
using System.Collections.Generic;
using System.IO;
using ShapesDataLayer;

namespace GeometricShapesFinal.business
{
    public partial class Form1 : Form
    {
        static string xmlFilePath = @"..\..\data\FileShapes.xml";
        List<Shapes> ListOfShapes = new List<Shapes>();

        public Form1()
        {
            InitializeComponent();

            this.cbSColor.DataSource = Enum.GetValues(typeof(EnumBrushingColor));
            this.cbBColor.DataSource = Enum.GetValues(typeof(EnumBorderColor));
        }

        private void Refresh()
        {

        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

        }

        /********************DRAW BUTTON*******************/
        private void BtDraw_Click(object sender, EventArgs e)
        {
            if (this.rbRectangle.Checked == true)
            {
                Rectangles myRectangle = new Rectangles();

                myRectangle.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                myRectangle.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                myRectangle.Width = Convert.ToDouble(this.tbHeight.Text);
                myRectangle.Length = Convert.ToDouble(this.tbLength.Text);
                myRectangle.ShapeBorderColor = (EnumBorderColor)cbBColor.SelectedItem;
                myRectangle.ShapeFillColor = (EnumBrushingColor)cbSColor.SelectedItem;
                myRectangle.ShapeType = EnumShapeType.rectangle;

                ListOfShapes.Add(myRectangle);
            }
            if (this.rbSquare.Checked == true)
            {
                Squares mySquare = new Squares();

                mySquare.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                mySquare.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                mySquare.Side = Convert.ToDouble(this.tbSide.Text);
                mySquare.ShapeBorderColor = (EnumBorderColor)cbBColor.SelectedItem;
                mySquare.ShapeFillColor = (EnumBrushingColor)cbSColor.SelectedItem;
                mySquare.ShapeType = EnumShapeType.square;

                ListOfShapes.Add(mySquare);
            }
            if (this.rbEllipses.Checked == true)
            {
                Ellipses myEllipse = new Ellipses();

                myEllipse.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                myEllipse.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                myEllipse.XRadius = Convert.ToDouble(this.tbXRadius.Text);
                myEllipse.YRadius = Convert.ToDouble(this.tbYRadius.Text);
                myEllipse.ShapeBorderColor = (EnumBorderColor)cbBColor.SelectedItem;
                myEllipse.ShapeFillColor = (EnumBrushingColor)cbSColor.SelectedItem;
                myEllipse.ShapeType = EnumShapeType.ellipse;

                ListOfShapes.Add(myEllipse);
            }
            if (this.rbCircle.Checked == true)
            {
                Circles myCircle = new Circles();

                myCircle.XCoord = Convert.ToInt32(this.tbXCoord.Text);
                myCircle.YCoord = Convert.ToInt32(this.tbYCoord.Text);
                myCircle.Radius = Convert.ToDouble(this.tbRadius.Text);
                myCircle.ShapeBorderColor = (EnumBorderColor)cbBColor.SelectedItem;
                myCircle.ShapeFillColor = (EnumBrushingColor)cbSColor.SelectedItem;
                myCircle.ShapeType = EnumShapeType.circle;

                ListOfShapes.Add(myCircle);
            }

            if (ListOfShapes.Count != 0)
            {
                this.listBoxShapes.Items.Clear();
                foreach (Shapes element in ListOfShapes)
                {
                    this.listBoxShapes.Items.Add(element);
                }
                this.btUp.Focus();
            }

            this.panelDraw.Invalidate();
            this.panelDraw.Update();
        }

        /********************EXIT BUTTON*******************/
        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /********************SAVE BUTTON*******************/
        private void BtSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlFilePath))
            {
                FileHandler.WriteToXmlFile(this.ListOfShapes);
            }
        }

        /********************LOAD BUTTON*******************/
        private void BtLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlFilePath))
            {
                this.ListOfShapes = FileHandler.ReadFromXmlFile();
            }
            else { MessageBox.Show("there is no Saved Data"); }

            foreach (Shapes item in ListOfShapes)
            {
                this.listBoxShapes.Items.Add(item);
            }
        }
    }
}
