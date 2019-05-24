using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer_v2
{
    class Triangle
    {
        Point vertex1;
        Point vertex2;
        Point vertex3;
        Color bodyColor = new Color();
        Color borderColor = new Color();
        public Bitmap bmp = new Bitmap(1, 1);

        public Triangle(Color bodyColor, Color borderColor, Point vertex1, Point vertex2, Point vertex3)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public void DrawFigure()
        {
            Point[] triangle =
            {
                vertex1,
                vertex2,
                vertex3
            };
            bmp = new Bitmap(759, 513);
            SolidBrush brush = new SolidBrush(bodyColor);
            Pen pen = new Pen(borderColor);
            pen.Width = 5;
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.DrawPolygon(pen, triangle);
            gfx.FillPolygon(brush, triangle);
        }

        //public bool isFigureClicked(int x, int y)
        //{
        //
        //    if ()
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
    }
}
