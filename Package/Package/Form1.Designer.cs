namespace Package
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClear = new Button();
            btnDrawEllipse = new Button();
            label11 = new Label();
            label10 = new Label();
            txtRadiusY = new TextBox();
            txtRadiusX = new TextBox();
            txtCenterYE = new TextBox();
            txtCenterXE = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnDrawCircle = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtRadius = new TextBox();
            txtCenterY = new TextBox();
            txtCenterX = new TextBox();
            btnChooseColor = new Button();
            btnDrawBresenham = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtY1 = new TextBox();
            txtX2 = new TextBox();
            txtY2 = new TextBox();
            txtX1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDrawDDA = new Button();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            comboReflectAxis = new ComboBox();
            btnReset = new Button();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            trackRotation = new TrackBar();
            trackShearY = new TrackBar();
            trackShearX = new TrackBar();
            trackScaleY = new TrackBar();
            trackScaleX = new TrackBar();
            trackTransY = new TrackBar();
            trackTransX = new TrackBar();
            listBoxOrder = new ListBox();
            checkShearing = new CheckBox();
            checkReflection = new CheckBox();
            checkRotation = new CheckBox();
            checkScaling = new CheckBox();
            checkTranslation = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackRotation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackShearY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackShearX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackScaleY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackScaleX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTransY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTransX).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 494);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnDrawEllipse);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtRadiusY);
            tabPage1.Controls.Add(txtRadiusX);
            tabPage1.Controls.Add(txtCenterYE);
            tabPage1.Controls.Add(txtCenterXE);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnDrawCircle);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtRadius);
            tabPage1.Controls.Add(txtCenterY);
            tabPage1.Controls.Add(txtCenterX);
            tabPage1.Controls.Add(btnChooseColor);
            tabPage1.Controls.Add(btnDrawBresenham);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtY1);
            tabPage1.Controls.Add(txtX2);
            tabPage1.Controls.Add(txtY2);
            tabPage1.Controls.Add(txtX1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnDrawDDA);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1054, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Algorithms";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(444, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 23);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDrawEllipse
            // 
            btnDrawEllipse.Location = new Point(6, 411);
            btnDrawEllipse.Name = "btnDrawEllipse";
            btnDrawEllipse.Size = new Size(138, 23);
            btnDrawEllipse.TabIndex = 28;
            btnDrawEllipse.Text = "Draw Ellipse";
            btnDrawEllipse.UseVisualStyleBackColor = true;
            btnDrawEllipse.Click += btnDrawEllipse_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(92, 365);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 27;
            label11.Text = "Radius Y";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 364);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 26;
            label10.Text = "Radius X";
            // 
            // txtRadiusY
            // 
            txtRadiusY.Location = new Point(92, 382);
            txtRadiusY.Name = "txtRadiusY";
            txtRadiusY.Size = new Size(52, 23);
            txtRadiusY.TabIndex = 25;
            // 
            // txtRadiusX
            // 
            txtRadiusX.Location = new Point(6, 382);
            txtRadiusX.Name = "txtRadiusX";
            txtRadiusX.Size = new Size(52, 23);
            txtRadiusX.TabIndex = 24;
            // 
            // txtCenterYE
            // 
            txtCenterYE.Location = new Point(92, 339);
            txtCenterYE.Name = "txtCenterYE";
            txtCenterYE.Size = new Size(52, 23);
            txtCenterYE.TabIndex = 23;
            // 
            // txtCenterXE
            // 
            txtCenterXE.Location = new Point(6, 339);
            txtCenterXE.Name = "txtCenterXE";
            txtCenterXE.Size = new Size(52, 23);
            txtCenterXE.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(92, 321);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 21;
            label9.Text = "Y Center";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 321);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 20;
            label8.Text = "X Center";
            // 
            // btnDrawCircle
            // 
            btnDrawCircle.Location = new Point(6, 272);
            btnDrawCircle.Name = "btnDrawCircle";
            btnDrawCircle.Size = new Size(138, 23);
            btnDrawCircle.TabIndex = 19;
            btnDrawCircle.Text = "Draw Circle";
            btnDrawCircle.UseVisualStyleBackColor = true;
            btnDrawCircle.Click += btnDrawCircle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 246);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Radius";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 217);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 17;
            label6.Text = "Y Center";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 188);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 16;
            label5.Text = "X Center";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(100, 243);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(44, 23);
            txtRadius.TabIndex = 15;
            // 
            // txtCenterY
            // 
            txtCenterY.Location = new Point(100, 214);
            txtCenterY.Name = "txtCenterY";
            txtCenterY.Size = new Size(44, 23);
            txtCenterY.TabIndex = 14;
            // 
            // txtCenterX
            // 
            txtCenterX.Location = new Point(100, 185);
            txtCenterX.Name = "txtCenterX";
            txtCenterX.Size = new Size(44, 23);
            txtCenterX.TabIndex = 13;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(150, 440);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(138, 23);
            btnChooseColor.TabIndex = 12;
            btnChooseColor.Text = "Choose Color";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // btnDrawBresenham
            // 
            btnDrawBresenham.Location = new Point(6, 134);
            btnDrawBresenham.Name = "btnDrawBresenham";
            btnDrawBresenham.Size = new Size(138, 23);
            btnDrawBresenham.TabIndex = 11;
            btnDrawBresenham.Text = "Draw Line Bresenham";
            btnDrawBresenham.UseVisualStyleBackColor = true;
            btnDrawBresenham.Click += btnDrawBresenham_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 14);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 10;
            label4.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 14);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 9;
            label3.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Point2:";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(97, 32);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(44, 23);
            txtY1.TabIndex = 7;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(47, 67);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(44, 23);
            txtX2.TabIndex = 6;
            // 
            // txtY2
            // 
            txtY2.Location = new Point(97, 67);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(44, 23);
            txtY2.TabIndex = 5;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(47, 32);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(44, 23);
            txtX1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(588, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 460);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Point1:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(432, 431);
            dataGridView1.TabIndex = 1;
            // 
            // btnDrawDDA
            // 
            btnDrawDDA.Location = new Point(6, 96);
            btnDrawDDA.Name = "btnDrawDDA";
            btnDrawDDA.Size = new Size(138, 23);
            btnDrawDDA.TabIndex = 0;
            btnDrawDDA.Text = "Draw Line DDA";
            btnDrawDDA.UseVisualStyleBackColor = true;
            btnDrawDDA.Click += btnDrawDDA_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(comboReflectAxis);
            tabPage2.Controls.Add(btnReset);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(trackRotation);
            tabPage2.Controls.Add(trackShearY);
            tabPage2.Controls.Add(trackShearX);
            tabPage2.Controls.Add(trackScaleY);
            tabPage2.Controls.Add(trackScaleX);
            tabPage2.Controls.Add(trackTransY);
            tabPage2.Controls.Add(trackTransX);
            tabPage2.Controls.Add(listBoxOrder);
            tabPage2.Controls.Add(checkShearing);
            tabPage2.Controls.Add(checkReflection);
            tabPage2.Controls.Add(checkRotation);
            tabPage2.Controls.Add(checkScaling);
            tabPage2.Controls.Add(checkTranslation);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1054, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transformations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(318, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(733, 460);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += PictureBox2_Paint;
            // 
            // comboReflectAxis
            // 
            comboReflectAxis.FormattingEnabled = true;
            comboReflectAxis.Items.AddRange(new object[] { "X", "Y", "XY" });
            comboReflectAxis.Location = new Point(191, 308);
            comboReflectAxis.Name = "comboReflectAxis";
            comboReflectAxis.Size = new Size(104, 23);
            comboReflectAxis.TabIndex = 22;
            comboReflectAxis.SelectedIndexChanged += comboBoxReflection_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(237, 397);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 311);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 20;
            label18.Text = "Radius";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(167, 223);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 19;
            label17.Text = "Y";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 223);
            label16.Name = "label16";
            label16.Size = new Size(14, 15);
            label16.TabIndex = 18;
            label16.Text = "X";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(167, 129);
            label15.Name = "label15";
            label15.Size = new Size(14, 15);
            label15.TabIndex = 17;
            label15.Text = "Y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 129);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 16;
            label14.Text = "X";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(167, 43);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 15;
            label13.Text = "Y";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 43);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 14;
            label12.Text = "X";
            // 
            // trackRotation
            // 
            trackRotation.Location = new Point(64, 300);
            trackRotation.Maximum = 180;
            trackRotation.Minimum = -180;
            trackRotation.Name = "trackRotation";
            trackRotation.Size = new Size(104, 45);
            trackRotation.TabIndex = 13;
            trackRotation.TickFrequency = 10;
            trackRotation.Scroll += trackBarRotate_Scroll;
            // 
            // trackShearY
            // 
            trackShearY.Location = new Point(191, 214);
            trackShearY.Maximum = 50;
            trackShearY.Minimum = -50;
            trackShearY.Name = "trackShearY";
            trackShearY.Size = new Size(104, 45);
            trackShearY.TabIndex = 12;
            trackShearY.Scroll += trackBarShearY_Scroll;
            // 
            // trackShearX
            // 
            trackShearX.Location = new Point(36, 214);
            trackShearX.Maximum = 50;
            trackShearX.Minimum = -50;
            trackShearX.Name = "trackShearX";
            trackShearX.Size = new Size(104, 45);
            trackShearX.TabIndex = 11;
            trackShearX.Scroll += trackBarShearX_Scroll;
            // 
            // trackScaleY
            // 
            trackScaleY.Location = new Point(191, 119);
            trackScaleY.Maximum = 50;
            trackScaleY.Minimum = -50;
            trackScaleY.Name = "trackScaleY";
            trackScaleY.Size = new Size(104, 45);
            trackScaleY.TabIndex = 10;
            trackScaleY.Scroll += trackBarScaleY_Scroll;
            // 
            // trackScaleX
            // 
            trackScaleX.Location = new Point(36, 119);
            trackScaleX.Maximum = 50;
            trackScaleX.Minimum = -50;
            trackScaleX.Name = "trackScaleX";
            trackScaleX.Size = new Size(104, 45);
            trackScaleX.TabIndex = 9;
            trackScaleX.Scroll += trackBarScaleX_Scroll;
            // 
            // trackTransY
            // 
            trackTransY.Location = new Point(191, 28);
            trackTransY.Maximum = 227;
            trackTransY.Minimum = -227;
            trackTransY.Name = "trackTransY";
            trackTransY.Size = new Size(104, 45);
            trackTransY.TabIndex = 8;
            trackTransY.Scroll += trackBarTranslateY_Scroll;
            // 
            // trackTransX
            // 
            trackTransX.Location = new Point(36, 28);
            trackTransX.Maximum = 366;
            trackTransX.Minimum = -366;
            trackTransX.Name = "trackTransX";
            trackTransX.Size = new Size(104, 45);
            trackTransX.TabIndex = 7;
            trackTransX.Scroll += trackBarTranslateX_Scroll;
            // 
            // listBoxOrder
            // 
            listBoxOrder.FormattingEnabled = true;
            listBoxOrder.ItemHeight = 15;
            listBoxOrder.Location = new Point(16, 365);
            listBoxOrder.Name = "listBoxOrder";
            listBoxOrder.Size = new Size(198, 94);
            listBoxOrder.TabIndex = 6;
            // 
            // checkShearing
            // 
            checkShearing.AutoSize = true;
            checkShearing.Location = new Point(5, 189);
            checkShearing.Name = "checkShearing";
            checkShearing.Size = new Size(72, 19);
            checkShearing.TabIndex = 5;
            checkShearing.Text = "Shearing";
            checkShearing.UseVisualStyleBackColor = true;
            checkShearing.CheckedChanged += checkBoxShearing_CheckedChanged;
            // 
            // checkReflection
            // 
            checkReflection.AutoSize = true;
            checkReflection.Location = new Point(191, 278);
            checkReflection.Name = "checkReflection";
            checkReflection.Size = new Size(79, 19);
            checkReflection.TabIndex = 4;
            checkReflection.Text = "Reflection";
            checkReflection.UseVisualStyleBackColor = true;
            checkReflection.CheckedChanged += checkBoxReflection_CheckedChanged;
            // 
            // checkRotation
            // 
            checkRotation.AutoSize = true;
            checkRotation.Location = new Point(6, 278);
            checkRotation.Name = "checkRotation";
            checkRotation.Size = new Size(71, 19);
            checkRotation.TabIndex = 3;
            checkRotation.Text = "Rotation";
            checkRotation.UseVisualStyleBackColor = true;
            checkRotation.CheckedChanged += checkBoxRotation_CheckedChanged;
            // 
            // checkScaling
            // 
            checkScaling.AutoSize = true;
            checkScaling.Location = new Point(7, 94);
            checkScaling.Name = "checkScaling";
            checkScaling.Size = new Size(64, 19);
            checkScaling.TabIndex = 2;
            checkScaling.Text = "Scaling";
            checkScaling.UseVisualStyleBackColor = true;
            checkScaling.CheckedChanged += checkBoxScaling_CheckedChanged;
            // 
            // checkTranslation
            // 
            checkTranslation.AutoSize = true;
            checkTranslation.Location = new Point(6, 6);
            checkTranslation.Name = "checkTranslation";
            checkTranslation.Size = new Size(83, 19);
            checkTranslation.TabIndex = 1;
            checkTranslation.Text = "Translation";
            checkTranslation.UseVisualStyleBackColor = true;
            checkTranslation.CheckedChanged += checkBoxTranslation_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 496);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Package";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackRotation).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackShearY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackShearX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackScaleY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackScaleX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTransY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTransX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtX1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDrawDDA;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtY1;
        private TextBox txtX2;
        private TextBox txtY2;
        private Button btnDrawBresenham;
        private Button btnChooseColor;
        private Button btnDrawCircle;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtRadius;
        private TextBox txtCenterY;
        private TextBox txtCenterX;
        private Label label10;
        private TextBox txtRadiusY;
        private TextBox txtRadiusX;
        private TextBox txtCenterYE;
        private TextBox txtCenterXE;
        private Label label9;
        private Label label8;
        private Button btnDrawEllipse;
        private Label label11;
        private Button btnClear;
        private CheckBox checkShearing;
        private CheckBox checkReflection;
        private CheckBox checkRotation;
        private CheckBox checkScaling;
        private CheckBox checkTranslation;
        private TrackBar trackTransY;
        private TrackBar trackTransX;
        private ListBox listBoxOrder;
        private TrackBar trackShearY;
        private TrackBar trackShearX;
        private TrackBar trackScaleY;
        private TrackBar trackScaleX;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private TrackBar trackRotation;
        private Label label18;
        private Button btnReset;
        private ComboBox comboReflectAxis;
        private PictureBox pictureBox2;
    }
}
