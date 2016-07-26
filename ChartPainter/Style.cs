using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ChartPainter
{
    public class Style
    {
        public Style(float width,Color borderColor,Color fillColor)
        {
            throw new System.NotImplementedException();
        }

        public Brush BorderColor { get; set; }

        public float Width { get; set; }

        public Color FillColor { get; set; }
    }
}
