using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public abstract class Shape
    {
        private string id;

        protected Shape()
            : this(Guid.NewGuid().ToString())
        { }

        protected Shape(string ID)
        {
            this.id = ID;
        }

        public string ID
        {
            get { return id; }
        }

        public abstract ShapeType ShapeType
        {
            get;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
