using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public struct Coordinate
    {
        private double x;
        private double y;

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            string x = X.ToString(CultureInfo.InvariantCulture);
            string y = Y.ToString(CultureInfo.InvariantCulture);
            return string.Format("({0},{1})", x, y);
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (typeof(Coordinate) == obj.GetType())
            {
                Coordinate vertex = (Coordinate)obj;
                if (this.X == vertex.X && this.Y == vertex.Y)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool operator ==(Coordinate vertex1, Coordinate vertex2)
        {
            return vertex1.Equals(vertex2);
        }

        public static bool operator !=(Coordinate vertex1, Coordinate vertex2)
        {
            return vertex1.Equals(vertex2);
        }

        public override int GetHashCode()
        {
            return (int)x ^ (int)y;
        }
    }

}
