using BillyardBalls;

namespace Diffusion
{
    public partial class mainForm : Form
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        private List<RandomColoredBall> balls;

        public mainForm()
        {
            InitializeComponent();

            x1 = ClientSize.Width / 2;
            x2 = ClientSize.Width / 2;
            y2 = ClientSize.Height;
            timer1.Interval = 5;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            balls = new List<RandomColoredBall>();

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomColoredBall(this, Brushes.DarkBlue, Side.Left);
                ball.onHited += Ball_onHited;
                balls.Add(ball);
            }

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomColoredBall(this, Brushes.DarkRed, Side.Right);
                ball.onHited += Ball_onHited;
                balls.Add(ball);
            }
        }

        private void Ball_onHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.LeftBlue:
                    leftBluePointLabel.Text = (int.Parse(leftBluePointLabel.Text) + 1).ToString();
                    break;
                case Side.RightBlue:
                    rightBluePointLabel.Text = (int.Parse(rightBluePointLabel.Text) + 1).ToString();
                    break;

                case Side.LeftRed:
                    leftRedPointLabel.Text = (int.Parse(leftRedPointLabel.Text) + 1).ToString();
                    break;
                case Side.RightRed:
                    rightRedPointLabel.Text = (int.Parse(rightRedPointLabel.Text) + 1).ToString();
                    break;

                case Side.UpBlue:
                    upBluePointLabel.Text = (int.Parse(upBluePointLabel.Text) + 1).ToString();
                    break;
                case Side.UpRed:
                    upRedPointLabel.Text = (int.Parse(upRedPointLabel.Text) + 1).ToString();
                    break;

                case Side.DownBlue:
                    downBluePointLabel.Text = (int.Parse(downBluePointLabel.Text) + 1).ToString();
                    break;
                case Side.DownRed:
                    downRedPointLabel.Text = (int.Parse(downRedPointLabel.Text) + 1).ToString();
                    break;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Show();
            }

            DrawCenterLine();

            if (IsMixed())
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }

        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var ball in balls)
            {
                if (!ball.IsMoveable())
                    ball.Start();
                else
                    ball.Stop();
            }
        }


        private void DrawCenterLine()
        {
            var graphics = CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(blackPen, x1, y1, x2, y2);
        }


        private bool IsMixed()
        {
            var leftBlueBallCount = 0;
            var rightBlueBallCount = 0;
            var leftRedBallCount = 0;
            var rightRedBallCount = 0;

            foreach (var ball in balls)
            {
                var x = ball.GetCoordinates()[0];

                if (x + ball.GetSize() < ClientSize.Width / 2)
                {
                    if (ball.GetColor() == Brushes.DarkBlue)
                        leftBlueBallCount++;

                    if (ball.GetColor() == Brushes.DarkRed)
                        leftRedBallCount++;
                }

                if (x - ball.GetSize() > ClientSize.Width / 2)              
                {
                    if (ball.GetColor() == Brushes.DarkBlue)
                        rightBlueBallCount++;

                    if (ball.GetColor() == Brushes.DarkRed)
                        rightRedBallCount++;
                }
            }


            if (leftBlueBallCount == rightBlueBallCount && leftRedBallCount == rightRedBallCount && leftBlueBallCount == leftRedBallCount && rightBlueBallCount == rightRedBallCount)
                return true;
            return false;
        }
        
    }
}