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
        int diameter;
        int x, y;
        Color bodyColor = new Color();
        Color borderColor = new Color();

        public Circle(Color bodyColor, Color borderColor, int radius, int x, int y)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            diameter = radius * 2;
            this.x = x - radius;
            this.y = y - radius;
        } 
        
        public void DrawFigure()
        {           
            SolidBrush brush = new SolidBrush(bodyColor);
            Pen pen = new Pen(borderColor);
            pen.Width = 5;
            main_form.gfx.DrawEllipse(pen, x, y, diameter, diameter);
            main_form.gfx.FillEllipse(brush, x+2.5F, y+2.5F, diameter-5, diameter-5);
        }

        public bool isFigureClicked(int x, int y)
        {            
            double xCenter = this.x + diameter/2;
            double yCenter = this.y + diameter/2;
            if (((Math.Pow((x - xCenter), 2)) + (Math.Pow((y - yCenter), 2))) < Math.Pow((diameter / 2), 2))
            {
                return true;
            }
            else
                return false;
        }
    }
}
