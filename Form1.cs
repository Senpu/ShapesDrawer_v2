using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesDrawer_v2
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        // Shapes drawn are stored in this list.
        List<Object> shapesDrawnList = new List<Object>();

        // Coordinates from drawing field.
        int x, y;

        // Colors for figures.
        Color bodyColor = new Color();
        Color borderColor = new Color();

        // Bitmap for drawing.
        Bitmap bmp = new Bitmap(759, 513);

        // Variables to store last drawn figure's coordinates.
        int figureX, figureY;

        int figureParam;

        Pen borderPen = new Pen(Color.Black);
        private void chooseShapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseShapeList.Text)
            {
                case "Circle":
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.DrawEllipse(borderPen, figureX, figureY, figureParam * 2, figureParam * 2);
            pictureBox.Image = bmp;
            gfx.Dispose();
        }

        private void btn_setShape_Click(object sender, EventArgs e)
        {
            switch (chooseBodyColor.Text)
            {
                case "Black":
                    bodyColor = Color.Black;
                    break;
                case "White":
                    bodyColor = Color.White;
                    break;
                case "Red":
                    bodyColor = Color.Red;
                    break;
                case "Green":
                    bodyColor = Color.Green;
                    break;
            }

            switch (chooseBorderColor.Text)
            {
                case "Black":
                    borderPen = new Pen(Color.Black);
                    borderPen.Width = 5;
                    borderColor = Color.Black;
                    break;
                case "White":
                    borderPen = new Pen(Color.White);
                    borderPen.Width = 5;
                    borderColor = Color.White;
                    break;
                case "Red":
                    borderPen = new Pen(Color.Red);
                    borderPen.Width = 5;
                    borderColor = Color.Red;
                    break;
                case "Green":
                    borderPen = new Pen(Color.Green);
                    borderPen.Width = 5;
                    borderColor = Color.Green;
                    break;
            }

            Int32.TryParse(shapeParam.Text, out int parsedParam);

            if (chooseShapeList.Text == "Circle")
            {
                Circle circle = new Circle(bodyColor, borderColor, parsedParam, x, y);
                figureX = circle.x;
                figureY = circle.y;
                figureParam = circle.radius;
                shapesDrawnList.Add(circle);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }


    }
}
