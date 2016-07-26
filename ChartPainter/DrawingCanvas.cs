using System.Drawing;

namespace ChartPainter
{
    public abstract class DrawingCanvas
    {
        private int width;
        private int height;
        private Color backgroundColor;

        public DrawingCanvas()
            : this(600, 800, Color.White)
        { }

        public DrawingCanvas(int Width, int Height, Color BackgroundColor)
        {
            this.width = Width;
            this.height = Height;
            this.backgroundColor = BackgroundColor;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
    }
}
