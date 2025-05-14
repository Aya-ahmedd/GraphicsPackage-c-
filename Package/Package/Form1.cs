using Package.Algorithms;

namespace Package
{

    public partial class Form1 : Form
    {
        Color selectedColor = Color.Black;
        TransformCircle circle;
        float translateX = 0, translateY = 0;
        float scaleX = 1, scaleY = 1;
        float rotateAngle = 0;
        float shearX = 0, shearY = 0;
        string reflectionAxis = "X";

        List<string> transformationsOrder = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();

            Graphics g = pictureBox1.CreateGraphics();
            DrawAxes(g);
        }
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                }
            }
        }
        private void DrawAxes(Graphics g)
        {
            //g.Clear(Color.White);
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            g.DrawLine(Pens.Gray, -pictureBox1.Width / 2, 0, pictureBox1.Width / 2, 0);
            g.DrawLine(Pens.Gray, 0, -pictureBox1.Height / 2, 0, pictureBox1.Height / 2);
        }

        private void btnDrawDDA_Click(object sender, EventArgs e)
        {

            int x1, y1, x2, y2;
            bool validInput = true;

            
            validInput &= int.TryParse(txtX1.Text, out x1);
            validInput &= int.TryParse(txtY1.Text, out y1);
            validInput &= int.TryParse(txtX2.Text, out x2);
            validInput &= int.TryParse(txtY2.Text, out y2);

            if (!validInput)
            {
                MessageBox.Show("Wrong Inputs");
                return;
            }

            dataGridView1.Columns.Clear();  
            dataGridView1.Columns.Add("k", "k");
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
            dataGridView1.Columns.Add("XY", "(X,Y)");  

            List<PointF> points = DDA.GetLinePoints(new Point(x1, y1), new Point(x2, y2));

            Graphics g = pictureBox1.CreateGraphics();
            DrawAxes(g);


            int k = 0;
            foreach (var point in points)
            {
                g.FillRectangle(new SolidBrush(selectedColor), point.X, -point.Y, 1, 1);
                dataGridView1.Rows.Add(k++, (int)point.X, (int)point.Y, $"({(int)point.X}, {(int)point.Y})");
            }
        }
        private void btnDrawBresenham_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;
            bool validInput = true;

            validInput &= int.TryParse(txtX1.Text, out x1);
            validInput &= int.TryParse(txtY1.Text, out y1);
            validInput &= int.TryParse(txtX2.Text, out x2);
            validInput &= int.TryParse(txtY2.Text, out y2);

            if (!validInput)
            {
                MessageBox.Show("Wrong Inputs");
                return;
            }

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("k", "k");
            dataGridView1.Columns.Add("Pk", "Pk");
            dataGridView1.Columns.Add("XY", "(X,Y)");

            List<(int Pk, Point point)> points = Bresenham.GetLinePoints(new Point(x1, y1), new Point(x2, y2));

            Graphics g = pictureBox1.CreateGraphics();
            DrawAxes(g);


            int k = 0;

            foreach (var (Pk, point) in points)
            {
                g.FillRectangle(new SolidBrush(selectedColor), point.X, -point.Y, 1, 1);  

                dataGridView1.Rows.Add(k++, Pk, $"({point.X}, {point.Y})");  
            }
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            DrawAxes(g);

            int centerX = int.Parse(txtCenterX.Text);
            int centerY = int.Parse(txtCenterY.Text);
            int radius = int.Parse(txtRadius.Text);

            Point center = new Point(centerX, centerY);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("k", "k");
            dataGridView1.Columns.Add("Pk", "Pk");
            dataGridView1.Columns.Add("Xk1", "Xk+1");
            dataGridView1.Columns.Add("Yk1", "Yk+1");
            dataGridView1.Columns.Add("2Xk1", "2Xk+1");
            dataGridView1.Columns.Add("2Yk1", "2Yk+1");

            Circle.DrawCircle(g, center, radius, selectedColor, dataGridView1);
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            DrawAxes(g);

            int centerX = int.Parse(txtCenterXE.Text);
            int centerY = int.Parse(txtCenterYE.Text);
            int rx = int.Parse(txtRadiusX.Text);
            int ry = int.Parse(txtRadiusY.Text);

            Point center = new Point(centerX, centerY);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("k", "k");
            dataGridView1.Columns.Add("P1k", "P1k");
            dataGridView1.Columns.Add("XY", "(Xk+1,Yk+1)");
            dataGridView1.Columns.Add("twoRy2X", "2Ry²Xk+1");
            dataGridView1.Columns.Add("twoRx2Y", "2Rx²Yk+1");

            Ellipse.DrawEllipse(g, center, rx, ry, selectedColor, dataGridView1);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            circle = new TransformCircle(pictureBox2.Width / 2, pictureBox2.Height / 2, 50);
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Graphics g = e.Graphics;
            circle.Draw(e.Graphics);
            Pen axisPen = new Pen(Color.LightGray, 1);

            g.DrawLine(axisPen, 0, pictureBox2.Height / 2, pictureBox2.Width, pictureBox2.Height / 2);
            g.DrawLine(axisPen, pictureBox2.Width / 2, 0, pictureBox2.Width / 2, pictureBox2.Height);

            axisPen.Dispose();
        }
        private void UpdateTransformation()
        {
            circle.Reset();

            foreach (string t in transformationsOrder)
            {
                switch (t)
                {
                    case "Translation":
                        TransformationManager.Translate(circle.transformedPoints, translateX, translateY);
                        break;
                    case "Scaling":
                        TransformationManager.Scale(circle.transformedPoints, scaleX, scaleY, circle.centerX, circle.centerY);
                        break;
                    case "Rotation":
                        TransformationManager.Rotate(circle.transformedPoints, rotateAngle, circle.centerX, circle.centerY);
                        break;
                    case "Reflection":
                        TransformationManager.Reflect(circle.transformedPoints, reflectionAxis, circle.centerX, circle.centerY);
                        break;
                    case "Shearing":
                        TransformationManager.Shear(circle.transformedPoints, shearX, shearY);
                        break;
                }
            }

            pictureBox2.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            translateX = translateY = shearX = shearY = 0;
            scaleX = scaleY = 1;
            rotateAngle = 0;
            reflectionAxis = "X";
            transformationsOrder.Clear();

            trackTransX.Value = 0;
            trackTransY.Value = 0;
            trackScaleX.Value = 0;
            trackScaleY.Value = 0;
            trackRotation.Value = 0;
            trackShearX.Value = 0;
            trackShearY.Value = 0;

            checkTranslation.Checked = false;
            checkScaling.Checked = false;
            checkRotation.Checked = false;
            checkReflection.Checked = false;
            checkShearing.Checked = false;

            listBoxOrder.Items.Clear();
            circle.Reset();
            pictureBox2.Invalidate();
        }
        private void trackBarTranslateX_Scroll(object sender, EventArgs e)
        {
            translateX = trackTransX.Value;
            UpdateTransformation();
        }
        private void trackBarTranslateY_Scroll(object sender, EventArgs e)
        {
            translateY = trackTransY.Value;
            UpdateTransformation();
        }
        private void checkBoxTranslation_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Translation";
            if (checkTranslation.Checked && !transformationsOrder.Contains(name))
                transformationsOrder.Add(name);
            else if (!checkTranslation.Checked)
                transformationsOrder.Remove(name);

            listBoxOrder.Items.Clear();
            listBoxOrder.Items.AddRange(transformationsOrder.ToArray());
            UpdateTransformation();
        }
        private void trackBarScaleX_Scroll(object sender, EventArgs e)
        {
            scaleX = trackScaleX.Value / 10.0f; 
            UpdateTransformation();
        }
        private void trackBarScaleY_Scroll(object sender, EventArgs e)
        {
            scaleY = trackScaleY.Value / 10.0f;
            UpdateTransformation();
        }
        private void checkBoxScaling_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Scaling";
            if (checkScaling.Checked && !transformationsOrder.Contains(name))
                transformationsOrder.Add(name);
            else if (!checkScaling.Checked)
                transformationsOrder.Remove(name);

            listBoxOrder.Items.Clear();
            listBoxOrder.Items.AddRange(transformationsOrder.ToArray());
            UpdateTransformation();
        }
        private void trackBarRotate_Scroll(object sender, EventArgs e)
        {
            rotateAngle = trackRotation.Value;
            UpdateTransformation();
        }

        private void checkBoxRotation_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Rotation";
            if (checkRotation.Checked && !transformationsOrder.Contains(name))
                transformationsOrder.Add(name);
            else if (!checkRotation.Checked)
                transformationsOrder.Remove(name);

            listBoxOrder.Items.Clear();
            listBoxOrder.Items.AddRange(transformationsOrder.ToArray());
            UpdateTransformation();
        }

        private void comboBoxReflection_SelectedIndexChanged(object sender, EventArgs e)
        {
            reflectionAxis = comboReflectAxis.SelectedItem.ToString();
            UpdateTransformation();
        }

        private void checkBoxReflection_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Reflection";
            if (checkReflection.Checked && !transformationsOrder.Contains(name))
                transformationsOrder.Add(name);
            else if (!checkReflection.Checked)
                transformationsOrder.Remove(name);

            listBoxOrder.Items.Clear();
            listBoxOrder.Items.AddRange(transformationsOrder.ToArray());
            UpdateTransformation();
        }

        private void trackBarShearX_Scroll(object sender, EventArgs e)
        {
            shearX = trackShearX.Value / 10.0f;
            UpdateTransformation();
        }

        private void trackBarShearY_Scroll(object sender, EventArgs e)
        {
            shearY = trackShearY.Value / 10.0f;
            UpdateTransformation();
        }
        private void checkBoxShearing_CheckedChanged(object sender, EventArgs e)
        {
            string name = "Shearing";
            if (checkShearing.Checked && !transformationsOrder.Contains(name))
                transformationsOrder.Add(name);
            else if (!checkShearing.Checked)
                transformationsOrder.Remove(name);

            listBoxOrder.Items.Clear();
            listBoxOrder.Items.AddRange(transformationsOrder.ToArray());
            UpdateTransformation();
        }
    }
}
