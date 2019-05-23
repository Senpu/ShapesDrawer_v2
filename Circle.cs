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
    class Circle
    {
        public int diameter;
        public int x, y;
        public Color bodyColor = new Color();
        public Color borderColor = new Color();
        public Bitmap bmp = new Bitmap(759, 513);

        public Circle(Color bodyColor, Color borderColor, int radius, int x, int y)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            diameter = radius * 2;
            this.x = x - radius;
            this.y = y - radius;
        } 
        
        public void DrawCircle()
        {
            SolidBrush brush = new SolidBrush(bodyColor);
            Pen pen = new Pen(borderColor);
            pen.Width = 5;
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.DrawEllipse(pen, x, y, diameter, diameter);
            gfx.FillEllipse(brush, x+2.5F, y+2.5F, diameter-5, diameter-5);
        }

        public bool isFigureClicked(int x, int y)
        {            
            double xCenter = x + diameter/2;
            double yCenter = y + diameter/2;
            if (((Math.Pow((x + xCenter), 2)) + (Math.Pow((y + yCenter), 2))) <= Math.Pow((diameter / 2), 2))
            {
                return true;
            }
            else
                return false;
        }
    }
}
