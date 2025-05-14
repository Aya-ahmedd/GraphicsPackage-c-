using System;
using System.Drawing;
using System.Windows.Forms;

namespace Package
{
    public class Circle
    {
        public static void DrawCircle(Graphics g, Point center, int radius, Color color, DataGridView dataGridView)
        {
            int x = 0;
            int y = radius;
            int Pk = 1 - radius;
            int k = 0;

            dataGridView.Rows.Clear();

            while (x <= y)
            {
                PlotCirclePoints(g, center, x, y, color);

                int twoX = 2 * x;
                int twoY = 2 * y;

                dataGridView.Rows.Add(k, Pk, x + 1, y + 1, twoX + 2, twoY + 2);

                if (Pk < 0)
                {
                    Pk += 2 * x + 3;
                }
                else
                {
                    Pk += 2 * (x - y) + 5;
                    y--;
                }

                x++;
                k++;
            }
        }

        private static void PlotCirclePoints(Graphics g, Point center, int x, int y, Color color)
        {
            Brush brush = new SolidBrush(color);

            g.FillRectangle(brush, center.X + x, -(center.Y + y), 1, 1);
            g.FillRectangle(brush, center.X - x, -(center.Y + y), 1, 1);
            g.FillRectangle(brush, center.X + x, -(center.Y - y), 1, 1);
            g.FillRectangle(brush, center.X - x, -(center.Y - y), 1, 1);
            g.FillRectangle(brush, center.X + y, -(center.Y + x), 1, 1);
            g.FillRectangle(brush, center.X - y, -(center.Y + x), 1, 1);
            g.FillRectangle(brush, center.X + y, -(center.Y - x), 1, 1);
            g.FillRectangle(brush, center.X - y, -(center.Y - x), 1, 1);
        }
    }
}
