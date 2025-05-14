using System;
using System.Collections.Generic;
using System.Drawing;

public static class Bresenham
{
    public static List<(int Pk, Point point)> GetLinePoints(Point p1, Point p2)
    {
        List<(int, Point)> points = new List<(int, Point)>();

        int x1 = p1.X, y1 = p1.Y;
        int x2 = p2.X, y2 = p2.Y;

        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);

        int sx = (x1 < x2) ? 1 : -1;
        int sy = (y1 < y2) ? 1 : -1;

        bool isSteep = dy > dx;
        if (isSteep)
        {
            int temp = dx;
            dx = dy;
            dy = temp;
        }

        int pk = 2 * dy - dx;  

        for (int i = 0; i <= dx; i++)
        {
            points.Add((pk, new Point(x1, y1)));

            if (pk < 0)
            {
                if (isSteep)
                    y1 += sy;
                else
                    x1 += sx;
                pk += 2 * dy;
            }
            else
            {
                x1 += sx;
                y1 += sy;
                pk += 2 * (dy - dx);
            }
        }

        return points;
    }
}

