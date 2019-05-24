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

        public bool isFigureClicked(int x, int y)
        {
            double square1, square2, square3, gSquare;
            double line1 = Math.Abs(Math.Pow((x - vertex1.X), 2) + Math.Pow((y - vertex1.Y), 2));
            double line2 = Math.Abs(Math.Pow((x - vertex2.X), 2) + Math.Pow((y - vertex2.Y), 2));
            double line3 = Math.Abs(Math.Pow((x - vertex3.X), 2) + Math.Pow((y - vertex3.Y), 2));
            double line4 = Math.Abs(Math.Pow((vertex1.X - vertex2.X), 2) + Math.Pow((vertex1.Y - vertex2.Y), 2));
            double line5 = Math.Abs(Math.Pow((vertex2.X - vertex3.X), 2) + Math.Pow((vertex2.Y - vertex3.Y), 2));
            double line6 = Math.Abs(Math.Pow((vertex3.X - vertex1.X), 2) + Math.Pow((vertex3.Y - vertex1.Y), 2));

            double halfp1 = (line1 + line2 + line4) / 2;
            double halfp2 = (line1 + line3 + line6) / 2;
            double halfp3 = (line2 + line3 + line5) / 2;
            double ghalfp = (line4 + line5 + line6) / 2;

            square1 = Math.Sqrt(halfp1 * (halfp1 - line1) * (halfp1 - line2) * (halfp1 - line4));
            square2 = Math.Sqrt(halfp2 * (halfp2 - line1) * (halfp2 - line3) * (halfp2 - line6));
            square3 = Math.Sqrt(halfp3 * (halfp3 - line2) * (halfp3 - line3) * (halfp3 - line5));

            gSquare = Math.Sqrt(ghalfp * (ghalfp - line4) * (ghalfp - line5) * (ghalfp - line6));

            if ((square1 + square2 + square3) == gSquare)
            {
                return true;
            }
            else
                return false;
        }
    }
}
