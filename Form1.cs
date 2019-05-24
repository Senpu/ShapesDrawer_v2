using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        // Creating an instance of a circle class with default parameters. 
        Circle circle = new Circle(Color.Black, Color.Black, 5, 1, 1);

        // Creating an instance of a square class with default parameters. 
        Square square = new Square(Color.Black, Color.Black, 5, 1, 1);

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Parsing user input to Int32.
            Int32.TryParse(shapeParam.Text, out int parsedParam);

            if (chooseShapeList.Text == "Circle")
            {
                circle = new Circle(bodyColor, borderColor, parsedParam, x, y);

                shapesDrawnList.Add(circle);

                circle.DrawFigure();

                circle.bmp.MakeTransparent();

                pictureBox.Image = circle.bmp;

                // Redraw();
            }

            else if (chooseShapeList.Text == "Square")
            {
                square = new Square(bodyColor, borderColor, parsedParam, x, y);

                shapesDrawnList.Add(square);

                square.DrawFigure();

                square.bmp.MakeTransparent();

                pictureBox.Image = square.bmp;

                // Redraw();
            }

        }

       // private void Redraw()
       // {
       //     shapesDrawnList.ForEach(item => item.DrawFigure());
       // }

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
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(circle.isFigureClicked(x, y) | square.isFigureClicked(x, y))
            {
                MessageBox.Show("Figure is selected");
            }
            else if (!(circle.isFigureClicked(x, y) | square.isFigureClicked(x, y)))
            {
                MessageBox.Show("Figure is not selected");
            }
        }

        private void chooseShapeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
