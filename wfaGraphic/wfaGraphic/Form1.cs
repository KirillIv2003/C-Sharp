namespace wfaGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.None;
            DrawAll();
            this.Resize += (s, e) => DrawAll();
        }

        private void DrawAll()
        {
            MyGraphic myGraphic = new(
                            this.ClientSize.Width,
                            this.ClientSize.Height);

            myGraphic.DrawAxes();
            myGraphic.DrawSin();
            myGraphic.DrawCos();
            myGraphic.DrawTan();

            this.BackgroundImage =
                (Bitmap)myGraphic.GetBitmap().Clone();
        }

        private void pbCharts_MouseMove(object sender, MouseEventArgs e)
        {
            MyGraphic myGraphic = new(
                            this.ClientSize.Width,
                            this.ClientSize.Height);

            myGraphic.Mouse(sender, e);
            //var b = new Bitmap(ClientSize.Width, ClientSize.Height);
            //var g = Graphics.FromImage(b);
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //myGraphic.g.DrawLine(Pens.Gray, new Point(0, e.Y), e.Location);
            //myGraphic.g.DrawLine(Pens.Gray, new Point(e.X, 0), e.Location);

            //var sin = myGraphic._sinValues[e.Location.X];
            //var cos = myGraphic._cosValues[e.Location.X];
            //var tan = myGraphic._tanValues[e.Location.X];

            //myGraphic.g.DrawString($"sin = {sin:F3}\ncos = {cos:F3}\ntan = {tan:F3}\n", Font, Brushes.Black, e.Location.X + 20, e.Location.Y);

            pbCharts1.Image = (Bitmap)myGraphic.GetBitmap().Clone();

            pbCharts1.Invalidate();
        }
    }
}