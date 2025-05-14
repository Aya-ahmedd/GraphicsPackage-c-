using System;
using System.Drawing;

namespace Package.Algorithms
{
    public static class DDA
    {
        public static List<PointF> GetLinePoints(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xIncrement = (float)dx / steps;
            float yIncrement = (float)dy / steps;

            float x = p1.X;
            float y = p1.Y;

            List<PointF> points = new List<PointF>();

            for (int i = 0; i <= steps; i++)
            {
                points.Add(new PointF(x, y));  

                x += xIncrement;
                y += yIncrement;
            }

            return points;  
        }
    }
}

