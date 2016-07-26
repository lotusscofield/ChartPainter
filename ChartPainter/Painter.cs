using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public class Painter
    {
        private GdiDrawingCanvas myCanvas;
        private Style style;
        private Shape shape;

        public Painter(GdiDrawingCanvas myCanvas, Shape shape, Style style)
        {
            this.myCanvas = myCanvas;
            this.shape = shape;
            this.style = style;
        }

        public void DrawShape(Shape shape, Style style)
        {
            Graphics graphics;
            graphics = Graphics.FromImage(myCanvas.FinalBitmap);
            Pen pen = new Pen(style.BorderColor, style.Width);
            Brush brush = new SolidBrush(style.FillColor);
            switch (shape.ShapeType)
            {
                case ShapeType.Line:
                    DrawLine(shape as LineSegment, graphics, pen);
                    break;
                case ShapeType.Polygon:
                    DrawPolygon(shape as Polygon, graphics, pen, brush);
                    break;
                default:
                    break;
            }
        }

        public object GetDrawingObject()
        {
            return myCanvas.FinalBitmap;
        }

        private void DrawLine(LineSegment line, Graphics graphics, Pen pen)
        {
            List<Point> pointList = new List<Point>();
            foreach (var vertex in line.Coordinates)
            {
                Point p = new Point((int)vertex.X, (int)vertex.Y);
                pointList.Add(p);
            }
            Point[] points = pointList.ToArray();
            graphics.DrawLines(pen, points);
        }

        private void DrawPolygon(Polygon polygon, Graphics graphics, Pen pen, Brush brush)
        {
            Point[] points = polygon.PolygonListToArray();
            graphics.DrawPolygon(pen, points);
            graphics.FillPolygon(brush, points);
        }
    }
}
