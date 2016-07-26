using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public class BarChart : Chart
    {
        private IEnumerable<double> datas;
        private GdiDrawingCanvas canvas;
        private Style style;
        private CoordinateSystem coordinateSystem;
        private int width;
        private int height;
        private string title;

        private BarChart()
            : this(new Collection<double>(), 1200, 800, "Untitled Bar Chart")
        { }

        public BarChart(IEnumerable<double> datas, int width, int height, string title)
        {
            this.datas = datas;
            this.width = width;
            this.height = height;
            this.title = title;
        }

        public double SpaceBetweenBars
        {
            get;
            set;
        }

        public void Show()
        {
            GdiDrawingCanvas myCanvas = new GdiDrawingCanvas(width, height);
            Shape shape = this.GetAllBars();
            Style style = new Style(1.0F, Color.Blue, Color.BlueViolet);
            Painter painter = new Painter(myCanvas, shape, style);
            painter.DrawShape(shape, style);
            CoordinateSystem coordinateSystem = new CoordinateSystem();
            coordinateSystem.showMeasurement(myCanvas);
        }

        public void Show(Style style)
        {
            GdiDrawingCanvas myCanvas = new GdiDrawingCanvas(width, height);
            Shape shape = this.GetAllBars();
            Painter painter = new Painter(myCanvas, shape, style);
            painter.DrawShape(shape, style);
            CoordinateSystem coordinateSystem = new CoordinateSystem();
            coordinateSystem.showMeasurement(myCanvas);
        }

        private Shape GetAllBars()
        {
            throw new NotImplementedException();
        }
    }
}
