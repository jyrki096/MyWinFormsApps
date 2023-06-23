using Balls.Common;


namespace BallsWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> randPointBalls;
        private PointBall pointBall;
        private int score;

        public MainForm()
        {
            InitializeComponent();
            stopAllBallsButton.Enabled = false;
        }

        private void DrawAndMoveManyBallsButton_Click(object sender, EventArgs e)
        {
            randPointBalls = new List<RandomMoveBall>();
            score = 0;

            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomMoveBall(this);
                randPointBalls.Add(ball);
                ball.Start();
            }
            stopAllBallsButton.Enabled = true;
            drawAndMoveManyBallsButton.Enabled = false;
        }

        private void StopAllBallsButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in randPointBalls)
            {
                ball.Stop();

                if (ball.IsCatched())
                {
                    score += 1;
                }
            }
            stopAllBallsButton.Enabled = false;
            MessageBox.Show($"Поймано {score} шариков");
        }


        private void RetryButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

    }
}