using Balls.Common;

namespace CatchMe2
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> randPointBalls;
        private PointBall pointBall;
        private int score;

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            randPointBalls = new List<RandomMoveBall>();
            score = 0;

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomMoveBall(this);
                ball.SetDirection();
                randPointBalls.Add(ball);
                ball.Start();
            }
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var ball in randPointBalls)
            {
                if (ball.Contains(e.X, e.Y) && ball.IsMoveable())
                {
                    ball.Stop();
                    if (ball.IsCatched())
                    {
                        score++;
                        scoreLabel.Text = score.ToString();
                        break;
                    }
                }
            }
        }
    }
}