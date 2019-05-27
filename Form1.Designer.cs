namespace ShapesDrawer_v2
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.shapeParam = new System.Windows.Forms.TextBox();
            this.chooseShapeList = new System.Windows.Forms.ComboBox();
            this.chooseBodyColor = new System.Windows.Forms.ComboBox();
            this.chooseBorderColor = new System.Windows.Forms.ComboBox();
            this.bodyColorLabel = new System.Windows.Forms.Label();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.chooseShapeLabel = new System.Windows.Forms.Label();
            this.btn_setShape = new System.Windows.Forms.Button();
            this.vertex1Label = new System.Windows.Forms.Label();
            this.vertex2Label = new System.Windows.Forms.Label();
            this.vertex3Label = new System.Windows.Forms.Label();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.shapeParamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(13, 126);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(759, 513);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1049, 491);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw shape";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(928, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear canvas";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // shapeParam
            // 
            this.shapeParam.Location = new System.Drawing.Point(1091, 173);
            this.shapeParam.Name = "shapeParam";
            this.shapeParam.Size = new System.Drawing.Size(121, 20);
            this.shapeParam.TabIndex = 3;
            // 
            // chooseShapeList
            // 
            this.chooseShapeList.FormattingEnabled = true;
            this.chooseShapeList.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Square"});
            this.chooseShapeList.Location = new System.Drawing.Point(954, 92);
            this.chooseShapeList.Name = "chooseShapeList";
            this.chooseShapeList.Size = new System.Drawing.Size(121, 21);
            this.chooseShapeList.TabIndex = 4;
            this.chooseShapeList.Text = "Choose shape...";
            this.chooseShapeList.SelectedIndexChanged += new System.EventHandler(this.chooseShapeList_SelectedIndexChanged);
            // 
            // chooseBodyColor
            // 
            this.chooseBodyColor.FormattingEnabled = true;
            this.chooseBodyColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Green"});
            this.chooseBodyColor.Location = new System.Drawing.Point(954, 291);
            this.chooseBodyColor.Name = "chooseBodyColor";
            this.chooseBodyColor.Size = new System.Drawing.Size(121, 21);
            this.chooseBodyColor.TabIndex = 5;
            this.chooseBodyColor.SelectedIndexChanged += new System.EventHandler(this.chooseBodyColor_SelectedIndexChanged);
            // 
            // chooseBorderColor
            // 
            this.chooseBorderColor.FormattingEnabled = true;
            this.chooseBorderColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Green"});
            this.chooseBorderColor.Location = new System.Drawing.Point(1091, 291);
            this.chooseBorderColor.Name = "chooseBorderColor";
            this.chooseBorderColor.Size = new System.Drawing.Size(121, 21);
            this.chooseBorderColor.TabIndex = 6;
            this.chooseBorderColor.SelectedIndexChanged += new System.EventHandler(this.chooseBorderColor_SelectedIndexChanged);
            // 
            // bodyColorLabel
            // 
            this.bodyColorLabel.AutoSize = true;
            this.bodyColorLabel.Location = new System.Drawing.Point(951, 272);
            this.bodyColorLabel.Name = "bodyColorLabel";
            this.bodyColorLabel.Size = new System.Drawing.Size(57, 13);
            this.bodyColorLabel.TabIndex = 7;
            this.bodyColorLabel.Text = "Body color";
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.AutoSize = true;
            this.borderColorLabel.Location = new System.Drawing.Point(1088, 272);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(64, 13);
            this.borderColorLabel.TabIndex = 8;
            this.borderColorLabel.Text = "Border color";
            // 
            // chooseShapeLabel
            // 
            this.chooseShapeLabel.AutoSize = true;
            this.chooseShapeLabel.Location = new System.Drawing.Point(951, 76);
            this.chooseShapeLabel.Name = "chooseShapeLabel";
            this.chooseShapeLabel.Size = new System.Drawing.Size(75, 13);
            this.chooseShapeLabel.TabIndex = 9;
            this.chooseShapeLabel.Text = "Choose shape";
            // 
            // btn_setShape
            // 
            this.btn_setShape.Location = new System.Drawing.Point(1049, 462);
            this.btn_setShape.Name = "btn_setShape";
            this.btn_setShape.Size = new System.Drawing.Size(75, 23);
            this.btn_setShape.TabIndex = 10;
            this.btn_setShape.Text = "Set shape";
            this.btn_setShape.UseVisualStyleBackColor = true;
            // 
            // vertex1Label
            // 
            this.vertex1Label.AutoSize = true;
            this.vertex1Label.Location = new System.Drawing.Point(857, 66);
            this.vertex1Label.Name = "vertex1Label";
            this.vertex1Label.Size = new System.Drawing.Size(0, 13);
            this.vertex1Label.TabIndex = 11;
            this.vertex1Label.Visible = false;
            // 
            // vertex2Label
            // 
            this.vertex2Label.AutoSize = true;
            this.vertex2Label.Location = new System.Drawing.Point(857, 87);
            this.vertex2Label.Name = "vertex2Label";
            this.vertex2Label.Size = new System.Drawing.Size(0, 13);
            this.vertex2Label.TabIndex = 12;
            this.vertex2Label.Visible = false;
            // 
            // vertex3Label
            // 
            this.vertex3Label.AutoSize = true;
            this.vertex3Label.Location = new System.Drawing.Point(857, 110);
            this.vertex3Label.Name = "vertex3Label";
            this.vertex3Label.Size = new System.Drawing.Size(0, 13);
            this.vertex3Label.TabIndex = 13;
            this.vertex3Label.Visible = false;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(793, 62);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(67, 17);
            this.rBtn1.TabIndex = 14;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "Vertex 1:";
            this.rBtn1.UseVisualStyleBackColor = true;
            this.rBtn1.Visible = false;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(793, 85);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(67, 17);
            this.rBtn2.TabIndex = 15;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "Vertex 2:";
            this.rBtn2.UseVisualStyleBackColor = true;
            this.rBtn2.Visible = false;
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(793, 108);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(67, 17);
            this.rBtn3.TabIndex = 16;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "Vertex 3:";
            this.rBtn3.UseVisualStyleBackColor = true;
            this.rBtn3.Visible = false;
            // 
            // shapeParamLabel
            // 
            this.shapeParamLabel.AutoSize = true;
            this.shapeParamLabel.Location = new System.Drawing.Point(1030, 176);
            this.shapeParamLabel.Name = "shapeParamLabel";
            this.shapeParamLabel.Size = new System.Drawing.Size(55, 13);
            this.shapeParamLabel.TabIndex = 17;
            this.shapeParamLabel.Text = "Parameter";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 651);
            this.Controls.Add(this.shapeParamLabel);
            this.Controls.Add(this.rBtn3);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.vertex3Label);
            this.Controls.Add(this.vertex2Label);
            this.Controls.Add(this.vertex1Label);
            this.Controls.Add(this.btn_setShape);
            this.Controls.Add(this.chooseShapeLabel);
            this.Controls.Add(this.borderColorLabel);
            this.Controls.Add(this.bodyColorLabel);
            this.Controls.Add(this.chooseBorderColor);
            this.Controls.Add(this.chooseBodyColor);
            this.Controls.Add(this.chooseShapeList);
            this.Controls.Add(this.shapeParam);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "main_form";
            this.Text = "Shapes Drawer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox shapeParam;
        private System.Windows.Forms.ComboBox chooseShapeList;
        private System.Windows.Forms.ComboBox chooseBodyColor;
        private System.Windows.Forms.ComboBox chooseBorderColor;
        private System.Windows.Forms.Label bodyColorLabel;
        private System.Windows.Forms.Label borderColorLabel;
        private System.Windows.Forms.Label chooseShapeLabel;
        private System.Windows.Forms.Button btn_setShape;
        private System.Windows.Forms.Label vertex1Label;
        private System.Windows.Forms.Label vertex2Label;
        private System.Windows.Forms.Label vertex3Label;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.Label shapeParamLabel;
    }
}

