using System;
using System.Drawing;
using System.Windows.Forms;

namespace Package
{
    public class Ellipse
    {
        public static void DrawEllipse(Graphics g, Point center, int rx, int ry, Color color, DataGridView dataGridView)
        {
            int x = 0;
            int y = ry;
            double rx2 = rx * rx;
            double ry2 = ry * ry;
            double p1 = ry2 - (rx2 * ry) + (0.25 * rx2);
            int k = 0;

            dataGridView.Rows.Clear();

            PlotEllipsePoints(g, center, x, y, color);

            double dx = 2 * ry2 * x;
            double dy = 2 * rx2 * y;

            while (dx < dy)
            {
                k++;
                x++;
                dx += 2 * ry2;

                if (p1 < 0)
                {
                    p1 += ry2 + dx;
                }
                else
                {
                    y--;
                    dy -= 2 * rx2;
                    p1 += ry2 + dx - dy;
                }

                PlotEllipsePoints(g, center, x, y, color);

                double twoRy2X = 2 * ry2 * x;
                double twoRx2Y = 2 * rx2 * y;
                dataGridView.Rows.Add(k, (int)p1, $"({x},{y})", (int)twoRy2X, (int)twoRx2Y);
            }

            double p2 = ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;
            while (y > 0)
            {
                k++;
                y--;
                dy -= 2 * rx2;

                if (p2 > 0)
                {
                    p2 += rx2 - dy;
                }
                else
                {
                    x++;
                    dx += 2 * ry2;
                    p2 += rx2 - dy + dx;
                }

                PlotEllipsePoints(g, center, x, y, color);

                double twoRy2X = 2 * ry2 * x;
                double twoRx2Y = 2 * rx2 * y;
                dataGridView.Rows.Add(k, (int)p2, $"({x},{y})", (int)twoRy2X, (int)twoRx2Y);
            }
        }

        private static void PlotEllipsePoints(Graphics g, Point center, int x, int y, Color color)
        {
            Brush brush = new SolidBrush(color);

            g.FillRectangle(brush, center.X + x, -(center.Y + y), 1, 1);
            g.FillRectangle(brush, center.X - x, -(center.Y + y), 1, 1);
            g.FillRectangle(brush, center.X + x, -(center.Y - y), 1, 1);
            g.FillRectangle(brush, center.X - x, -(center.Y - y), 1, 1);
        }
    }
}

