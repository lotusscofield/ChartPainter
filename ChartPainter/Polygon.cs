using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public class Polygon : Shape
    {
        private Collection<Coordinate> coordinates;

        public Polygon()
            : this(new Collection<Coordinate>())
        { }

        public Polygon(IEnumerable<Coordinate> coordinates)
        {
            foreach (var coordinate in coordinates)
            {
                this.Coordinates.Add(coordinate);
            }
        }

        public Collection<Coordinate> Coordinates
        {
            get
            {
                if (coordinates == null)
                {
                    coordinates = new Collection<Coordinate>();
                }
                return coordinates;
            }
            private set { coordinates = value; }
        }

        public override ShapeType ShapeType
        {
            get { return ShapeType.Polygon; }
        }

        public override double GetArea()
        {
            double area = 0;
            Point[] points = this.PolygonListToArray();

            for (int i = 0; i < points.Length; i++)
            {
                area += points[i].X * points[(i + 1) % points.Length].Y - points[(i + 1) % points.Length].X * points[i].Y;
            }

            return Math.Abs(0.5 * area);
        }

        public override double GetPerimeter()
        {
            double perimeter = 0;
            Point[] points = this.PolygonListToArray();

            for (int i = 0; i < points.Length; i++)
            {
                perimeter += Math.Sqrt((points[i].X - points[(i + 1) % points.Length].X) ^ 2
                                     + (points[i].Y - points[(i + 1) % points.Length].Y) ^ 2);

            }

            return perimeter;
        }

        internal Point[] PolygonListToArray()
        {
            List<Point> polygonList = new List<Point>();
            foreach (var coordinate in this.Coordinates)
            {
                Point p = new Point((int)coordinate.X, (int)coordinate.Y);
                polygonList.Add(p);
            }
            Point[] points = polygonList.ToArray();

            return points;
        }
    }
}
