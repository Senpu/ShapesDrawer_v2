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

        // Points for triangle's vertexes.
        Point vertex1, vertex2, vertex3;

        // Default points for a triangle's vertexes.
        static Point defpoint1 = new Point(1, 1);
        static Point defpoint2 = new Point(1, 1);
        static Point defpoint3 = new Point(1, 1);

        // Colors for figures.
        Color bodyColor = new Color();
        Color borderColor = new Color();

        //Canvas to draw on.
        static public Bitmap bmp = new Bitmap(759, 513);
        static public Graphics gfx = Graphics.FromImage(bmp);
    
        // Creating an instance of a circle class with default parameters. 
        Circle circle = new Circle(Color.Black, Color.Black, 5, 1, 1);

        // Creating an instance of a square class with default parameters. 
        Square square = new Square(Color.Black, Color.Black, 5, 1, 1);

        // Creating an instance of a triangle class with default parameters. 
        Triangle triangle = new Triangle(Color.Black, Color.Black, defpoint1, defpoint2, defpoint3);

        // Creating delegate to use figure's draw methods when redrawing canvas.
        delegate void Redraw();
        Redraw redraw;

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Parsing user input to Int32.
            Int32.TryParse(shapeParam.Text, out int parsedParam);

            if (chooseShapeList.Text == "Circle")
            {
                circle = new Circle(bodyColor, borderColor, parsedParam, x, y);
                shapesDrawnList.Add(circle);
                circle.DrawFigure();
                bmp.MakeTransparent();
                pictureBox.Image = bmp;
            }

            else if (chooseShapeList.Text == "Square")
            {
                square = new Square(bodyColor, borderColor, parsedParam, x, y);
                shapesDrawnList.Add(square);
                square.DrawFigure();
                bmp.MakeTransparent();
                pictureBox.Image = bmp;
            }

            else if (chooseShapeList.Text == "Triangle")
            {
                triangle = new Triangle(bodyColor, borderColor, vertex1, vertex2, vertex3);
                shapesDrawnList.Add(triangle);
                triangle.DrawFigure();
                bmp.MakeTransparent();
                pictureBox.Image = bmp;
            }

        }

        private void chooseBodyColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(chooseBodyColor.Text)
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
        }

        private void chooseBorderColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseBorderColor.Text)
            {
                case "Black":
                    borderColor = Color.Black;
                    break;
                case "White":
                    borderColor = Color.White;
                    break;
                case "Red":
                    borderColor = Color.Red;
                    break;
                case "Green":
                    borderColor = Color.Green;
                    break;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            if (rBtn1.Checked == true)
            {
                vertex1Label.Text = ($"X: {x}, Y: {y}");
                vertex1.X = x;
                vertex1.Y = y;
            }
            else if (rBtn2.Checked == true)
            {
                vertex2Label.Text = ($"X: {x}, Y: {y}");
                vertex2.X = x;
                vertex2.Y = y;
            }
            else if (rBtn3.Checked == true)
            {
                vertex3Label.Text = ($"X: {x}, Y: {y}");
                vertex3.X = x;
                vertex3.Y = y;
            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (circle.isFigureClicked(x, y) | square.isFigureClicked(x, y) | triangle.isFigureClicked(x, y))
            {
                MessageBox.Show("Figure is selected");
            }
            else if (!(circle.isFigureClicked(x, y) | square.isFigureClicked(x, y)) | triangle.isFigureClicked(x, y))
            {
                MessageBox.Show("Figure is not selected");
            }
        }

        private void chooseShapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseShapeList.Text)
            {
                case "Circle":
                    vertex1Label.Visible = false;
                    vertex2Label.Visible = false;
                    vertex3Label.Visible = false;
                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    shapeParamLabel.Text = "Radius:";
                    shapeParamLabel.Location = new Point(1044, 176);
                    break;

                case "Triangle":
                    vertex1Label.Visible = true;
                    vertex2Label.Visible = true;
                    vertex3Label.Visible = true;
                    rBtn1.Visible = true;
                    rBtn2.Visible = true;
                    rBtn3.Visible = true;
                    shapeParamLabel.Text = "Parameter:";
                    shapeParamLabel.Location = new Point(1030, 176);
                    break;

                case "Square":
                    vertex1Label.Visible = false;
                    vertex2Label.Visible = false;
                    vertex3Label.Visible = false;
                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    shapeParamLabel.Text = "Side:";
                    shapeParamLabel.Location = new Point(1052, 176);
                    break;

                default:
                    break;
            }
        }

    }
}
