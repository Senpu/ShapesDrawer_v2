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
    class Square
    {
        int side;
        int x, y;
        Color bodyColor = new Color();
        Color borderColor = new Color();

        public Square(Color bodyColor, Color borderColor, int side, int x, int y)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            this.x = x - side / 2;
            this.y = y - side / 2;
            this.side = side;
        }

        public void DrawFigure()
        {
            SolidBrush brush = new SolidBrush(bodyColor);
            Pen pen = new Pen(borderColor);
            pen.Width = 5;
            main_form.gfx.DrawRectangle(pen, x, y, side, side);
            main_form.gfx.FillRectangle(brush, x + 2.5F, y + 2.5F, side - 5, side - 5);
        }

        public bool isFigureClicked(int x, int y)
        {            
            int xRightBottomVertex = this.x + side;
            int yRightBottomVertex = this.y + side;
            if ((x >= this.x && x <= xRightBottomVertex) && (y >= this.y && y <= yRightBottomVertex))
            {
                return true;
            }
            else
                return false;
        }
    }
}
