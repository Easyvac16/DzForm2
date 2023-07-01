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
                string message = default;
                if (_rectangle.Contains(e.Location))
                {
                    message = "����� ����������� �������� ������������.";
                }
                else if (_rectangle.IntersectsWith(new Rectangle(e.X, e.Y, 2, 2)))
                {
                    message = "����� ����������� �� ��� ������������.";
                }
                else
                {
                    message = "����� ����������� ���� ������������.";
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
                this.Text = $"������ = {this.ClientSize.Width}, ������ = {this.ClientSize.Height}";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + e.X + ", Y = " + e.Y;
        }

    }
}