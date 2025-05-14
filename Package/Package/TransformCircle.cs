using System.Drawing;
using System.Collections.Generic;

public class TransformCircle
{
    public int centerX, centerY, radius;
    public List<Point> originalPoints;
    public List<PointF> transformedPoints;

    public TransformCircle(int x, int y, int r)
    {
        centerX = x;
        centerY = y;
        radius = r;
        originalPoints = new List<Point>();
        transformedPoints = new List<PointF>();
        GenerateCirclePoints();
    }

    private void GenerateCirclePoints()
    {
        originalPoints.Clear();
        for (int angle = 0; angle < 360; angle++)
        {
            double rad = angle * Math.PI / 180;
            int x = (int)(centerX + radius * Math.Cos(rad));
            int y = (int)(centerY + radius * Math.Sin(rad));
            originalPoints.Add(new Point(x, y));
        }
        Reset();
    }

    public void Reset()
    {
        transformedPoints.Clear();
        foreach (var p in originalPoints)
            transformedPoints.Add(new PointF(p.X, p.Y));
    }

    public void Draw(Graphics g)
    {
        foreach (var p in transformedPoints)
        {
            g.FillRectangle(Brushes.Red, p.X, p.Y, 3, 3);
        }
    }
}
