using System;
using System.Windows.Forms;

namespace ShapesDataLayer.business
{
    //1.1
    interface IShape2D
    {
        //1.1.1
        void Draw(PaintEventArgs e);
        //1.1.2
        void Draw(PaintEventArgs e, String brushingColor);
        //1.1.3
        void Draw(PaintEventArgs e, String borderColor, String brushingColor);
        //1.1.4
        void moveUp(int dy);
        void moveDown(int dy);
        void moveLeft(int dx);
        void moveRight(int dx);
        //1.1.5
        void moveUpRight(int dx, int dy);
        void moveDownRight(int dx, int dy);
        void moveUpLeft(int dx, int dy);
        void moveDownLeft(int dx, int dy);
    }
}
