using System.ComponentModel;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseMove += (s, e) =>
            {
                OnMouseMove(e);
            };
        }

        private void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            label3.Text = string.Format($"{e.X} {e.Y}");
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            numericUpDown1.Value = pictureBox1.Width / numericUpDown3.Value;
            numericUpDown2.Value = pictureBox1.Height / numericUpDown3.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            g.Clear(Color.AliceBlue);

            int n = (int)numericUpDown1.Value;
            int m = (int)numericUpDown2.Value;
            int px = (int)numericUpDown3.Value;

            for (int column = 0; column <= n; column++)
            {
                g.DrawLine(Pens.Blue, column * px, 0, column * px, m * px);
            }

            for (int row = 0; row <= m; row++)
            {
                g.DrawLine(Pens.Blue, 0, row * px, n * px, row * px);
            }
        }
    }
}