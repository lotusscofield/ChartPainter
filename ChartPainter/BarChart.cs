using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChartPainter
{
    public class BarChart : Chart
    {
        public BarChart(IEnumerable<double> data)
        {
 
        }
        public void Show()
        {
            GdiDrawingCanvas myCanvas = new GdiDrawingCanvas();
            Shape shape = this.GetAllBars();
            Style style = new Style(1.0F,Color.Blue,Color.BlueViolet);
            Painter painter = new Painter(myCanvas, shape, style);
            painter.DrawShape();
            CoordinateSystem coordinateSystem = new CoordinateSystem();
            coordinateSystem.showMeasurement(myCanvas);
        }

        public void Show(Style style)
        {
            GdiDrawingCanvas myCanvas = new GdiDrawingCanvas();
            Shape shape = this.GetAllBars();
            Painter painter = new Painter(myCanvas,shape,style);
            painter.DrawShape();
            CoordinateSystem coordinateSystem = new CoordinateSystem();
            coordinateSystem.showMeasurement(myCanvas);
        }

        private Shape GetAllBars()
        {
            throw new NotImplementedException();
        }
    }
}
