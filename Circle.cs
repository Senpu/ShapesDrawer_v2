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
        public int radius;
        public int x, y;
        public Color bodyColor = new Color();
        public Color borderColor = new Color();
        public Circle(Color bodyColor, Color borderColor, int radius, int x, int y)
        {
            this.bodyColor = bodyColor;
            this.borderColor = borderColor;
            this.radius = radius;
            this.x = x - radius;
            this.y = y - radius;
        }        
    }
}
