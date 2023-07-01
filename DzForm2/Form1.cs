namespace DzForm2
{
    public partial class Form1 : Form
    {
        private Rectangle _rectangle;

        public Form1()
        {
            InitializeComponent();
            _rectangle = new Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                List<Rectangle> rectangles =  new List<Rectangle>();
                rectangles.Add(_rectangle);

                rectangles.FirstOrDefault(rect => rect.Contains(e.Location));

                var rect = _rectangle.Contains(e.Location);





                string message = default;
                if (rect)
                {
                    message = "Точка знаходиться всередині прямокутника.";
                }
                else if (rectangles.FirstOrDefault(rect => rect.IntersectsWith(new Rectangle(e.X, e.Y, 2, 2)))
                {
                    message = "Точка знаходиться на межі прямокутника.";
                }
                else
                {
                    message = "Точка знаходиться зовні прямокутника.";
                }

                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = $"Ширина = {this.ClientSize.Width}, Висота = {this.ClientSize.Height}";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + e.X + ", Y = " + e.Y;
        }

    }
}