using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public class LineSegment : Shape
    {
        private Collection<Coordinate> coordinates;

        public LineSegment()
            : this(new Collection<Coordinate>())
        { }

        public LineSegment(IEnumerable<Coordinate> coordinates)
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
            get { return ShapeType.Line; }
        }

        public override double GetArea()
        {
            return 0;
        }

        public override double GetPerimeter()
        {
            return 0;
        }
    }
}
