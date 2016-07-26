using System.Drawing;

namespace ChartPainter
{
    public class GdiDrawingCanvas : DrawingCanvas
    {
        private Graphics graphics;
        private Bitmap finalBitmap;
        private int Width;
        private int Height;
    
        public GdiDrawingCanvas(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.finalBitmap = new Bitmap(Width, Height);
        }

        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }

        public Bitmap FinalBitmap
        {
            get { return finalBitmap; }
            set { finalBitmap = value; }
        }
    }
}
