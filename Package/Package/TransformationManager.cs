using System;
using System.Collections.Generic;
using System.Drawing;

public class TransformationManager
{
    public static void Translate(List<PointF> points, float dx, float dy)
    {
        for (int i = 0; i < points.Count; i++)
            points[i] = new PointF(points[i].X + dx, points[i].Y + dy);
    }

    public static void Scale(List<PointF> points, float sx, float sy, float cx, float cy)
    {
        for (int i = 0; i < points.Count; i++)
        {
            float x = points[i].X - cx;
            float y = points[i].Y - cy;
            points[i] = new PointF(x * sx + cx, y * sy + cy);
        }
    }

    public static void Rotate(List<PointF> points, float angleDeg, float cx, float cy)
    {
        double angle = angleDeg * Math.PI / 180;
        for (int i = 0; i < points.Count; i++)
        {
            float x = points[i].X - cx;
            float y = points[i].Y - cy;

            float xNew = (float)(x * Math.Cos(angle) - y * Math.Sin(angle));
            float yNew = (float)(x * Math.Sin(angle) + y * Math.Cos(angle));

            points[i] = new PointF(xNew + cx, yNew + cy);
        }
    }

    public static void Reflect(List<PointF> points, string axis, float cx, float cy)
    {
        for (int i = 0; i < points.Count; i++)
        {
            float x = points[i].X - cx;
            float y = points[i].Y - cy;

            switch (axis)
            {
                case "X": y = -y; break;
                case "Y": x = -x; break;
                case "XY": x = -x; y = -y; break;
            }

            points[i] = new PointF(x + cx, y + cy);
        }
    }

    public static void Shear(List<PointF> points, float shx, float shy)
    {
        for (int i = 0; i < points.Count; i++)
        {
            float x = points[i].X;
            float y = points[i].Y;

            float xNew = x + shx * y;
            float yNew = y + shy * x;

            points[i] = new PointF(xNew, yNew);
        }
    }
}
