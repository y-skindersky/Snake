using System.ComponentModel;
using Timer = System.Threading.Timer;

namespace Snake
{
    public partial class Form1 : Form
    {
        private MySnake snake;
        private Timer timer;

        public static int n;
        public static int m;
        private int px;

        public Form1()
        {
            InitializeComponent();

            KeyPreview = true;
            pictureBox1.MouseMove += (s, e) =>
            {
                OnMouseMove(e);
            };
            timer = new Timer(OnTimer);
            timer.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

        private void OnTimer(object? state)
        {
            if (snake == null)
                return;

            var g = pictureBox1.CreateGraphics();

            g.FillRectangle(Brushes.AliceBlue, new Rectangle(
                (snake.Tail.x - 1) * px + 1, (snake.Tail.y - 1) * px + 1, px - 2, px - 2));
            snake.Move();

            DrawSnake(snake, g, px);
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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (snake == null)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Up:
                    snake.TurnUp();
                    break;
                case Keys.Down:
                    snake.TurnDown();
                    break;
                case Keys.Left:
                    snake.TurnLeft();
                    break;
                case Keys.Right:
                    snake.TurnRight();
                    break;
                default:
                    break;
            }

            base.OnKeyDown(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            m = (int)numericUpDown2.Value;
            px = (int)numericUpDown3.Value;

            var g = pictureBox1.CreateGraphics();
            DrawField(g);

            snake = new MySnake();

            DrawSnake(snake, g, px);
        }

        private void DrawField(Graphics g)
        {
            g.Clear(Color.AliceBlue);

            for (int column = 0; column <= n; column++)
            {
                g.DrawLine(Pens.Blue, column * px, 0, column * px, m * px);
            }

            for (int row = 0; row <= m; row++)
            {
                g.DrawLine(Pens.Blue, 0, row * px, n * px, row * px);
            }
        }

        private void DrawSnake(MySnake snake, Graphics g, int px)
        {
            foreach (var part in snake.Body)
            {
                g.FillRectangle(Brushes.RoyalBlue,
                    new Rectangle((part.x - 1) * px + 1, (part.y - 1) * px + 1, px - 2, px - 2));
            }
        }
    }

    internal class MySnake
    {
        private Queue<(int x, int y)> body = new Queue<(int x, int y)>();
        private int movX = 1;
        private int movY = 0;

        public MySnake()
        {
            body.Enqueue((1, 1)); // 1, 1
            body.Enqueue((2, 1)); // 2, 1
            body.Enqueue((3, 1)); // 3, 1
        }

        public IEnumerable<(int x, int y)> Body
        {
            get
            {
                return body.ToArray();
            }
        }

        public (int x, int y) Tail
        {
            get
            {
                return body.Peek();
            }
        }

        public void Move()
        {
            var head = body.Last();
            var x = head.x + movX;
            var y = head.y + movY;
            if (x > Form1.n)
                x = 1;
            if (y > Form1.m)
                y = 1;
            if (x < 1)
                x = Form1.n;
            if (y < 1)
                y = Form1.m;
            body.Enqueue((x, y));
            body.Dequeue();
        }

        public void TurnDown()
        {
            movX = 0;
            movY = 1;
        }

        public void TurnUp()
        {
            movX = 0;
            movY = -1;
        }

        public void TurnLeft()
        {
            movX = -1;
            movY = 0;
        }

        public void TurnRight()
        {
            movX = 1;
            movY = 0;
        }
    }
}