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
        public int side;
        public int x, y;
        public Color bodyColor = new Color();
        public Color borderColor = new Color();
        public Bitmap bmp = new Bitmap(1, 1);

        public Square(Color bodyColor, Color borderColor, int side, int x, int y)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            this.x = x - side;
            this.y = y - side;
            this.side = side;
        }

        public void DrawFigure()
        {
            bmp = new Bitmap(759, 513);
            SolidBrush brush = new SolidBrush(bodyColor);
            Pen pen = new Pen(borderColor);
            pen.Width = 5;
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.DrawRectangle(pen, x + side / 2, y + side / 2, side, side);
            gfx.FillRectangle(brush, x + side / 2 + 2.5F, y + side / 2 + 2.5F, side - 5, side - 5);
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
