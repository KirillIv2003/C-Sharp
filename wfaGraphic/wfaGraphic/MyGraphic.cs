using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wfaGraphic
{
    internal class MyGraphic
    {        
        public int Width { get; }
        public int Height { get; }
        public int CountWave { get; } = 5;
        public int DotDiameter { get; } = 4;

        private Bitmap b;
        private Graphics g;
        private int grShiftY;
        private double grHeight;
        private double grWidthPI;

        public readonly Dictionary<int, double> _sinValues = new();
        public readonly Dictionary<int, double> _cosValues = new();
        public readonly Dictionary<int, double> _tanValues = new();

        public MyGraphic(int width, int height)
        {
            Width = width;
            Height = height;

            b = new Bitmap(width, height);
            g = Graphics.FromImage(b);

            grShiftY = b.Height / 2;
            grHeight = grShiftY * 0.9;
            grWidthPI = Math.PI / b.Width;
        }

        internal void DrawAxes()
        {
            // ось x
            //g.DrawLine(new Pen(Color.Black), 0, grShiftY, b.Width, grShiftY);
            g.DrawLine(Pens.Black, 0, grShiftY, b.Width, grShiftY);
            for (int i = 0; i < CountWave; i++)
            {
                var _x = b.Width / CountWave * i;
                g.DrawLine(Pens.Black, _x, grShiftY - 20, _x, grShiftY + 20);
                g.DrawString($"{i}PI", new Font("", 10), new SolidBrush(Color.Black), _x + 10, grShiftY - 40);
            }


            // ось y
            g.DrawLine(Pens.Black, 0, 0, 0, b.Height);
        }

        internal Bitmap? GetBitmap()
        {
            return b;
        }

        internal void DrawSin()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Sin(_x * CountWave * grWidthPI) + grShiftY;
                g.FillEllipse(new SolidBrush(Color.Red),
                    (int)_x - DotDiameter / 2, (int)_y - DotDiameter / 2,
                    DotDiameter, DotDiameter);
                _sinValues[i] = _y;
            }
        }

        internal void DrawCos()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Cos(_x * CountWave * grWidthPI) + grShiftY;
                g.FillEllipse(new SolidBrush(Color.Green),
                    (int)_x - DotDiameter / 2, (int)_y - DotDiameter / 2,
                    DotDiameter, DotDiameter);
                _cosValues[i] = _y;
            }
        }

        internal void DrawTan()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Tan(_x * CountWave * grWidthPI) + grShiftY;
                if (_y > 0 && _y < b.Height)
                {
                    g.FillEllipse(new SolidBrush(Color.Blue),
                        (int)_x - DotDiameter / 2, (int)_y - DotDiameter / 2,
                        DotDiameter, DotDiameter);
                    _tanValues[i] = _y;
                }
                
            }
        }

        internal void Mouse(object sender, MouseEventArgs e)
        {
            g.DrawLine(Pens.Gray, new Point(0, e.Y), e.Location);
            g.DrawLine(Pens.Gray, new Point(e.X, 0), e.Location);

            var sin = _sinValues[e.Location.X];
            var cos = _cosValues[e.Location.X];
            var tan = _tanValues[e.Location.X];

            g.DrawString($"sin = {sin:F3}\ncos = {cos:F3}\ntan = {tan:F3}\n", new Font("", 10), Brushes.Black, e.Location.X + 20, e.Location.Y);

        }
    }
}