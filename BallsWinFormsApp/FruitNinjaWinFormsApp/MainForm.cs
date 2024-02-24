using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class mainForm : Form
    {
        private List<FruitBall> balls;
        private Random random = new Random();
        private Timer slowTimer = new Timer();
        private int slowSecondsRemain = 2;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            balls = new List<FruitBall>();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Interval = 1000;
            startButton.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var bombNumber = random.Next(10);
                var fruit = bombNumber == 4 ? new BombBall(this) : bombNumber == 5 ? new BananaBall(this) : new FruitBall(this);            
                balls.Add(fruit);
                fruit.Start();
            }

            timer.Interval = random.Next(2000, 5000);
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (balls != null)
            {
                foreach (var fruit in balls)
                {
                    if (fruit.IsMoveable() && fruit.IsCatched() && fruit.Contains(e.X, e.Y))
                    {
                        if (fruit is BombBall)
                        {
                            EndGame();
                            return;
                        }

                        if (fruit is BananaBall)
                            SlowDown();

                        fruit.Stop();
                        fruit.Clear();
                        scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();
                    }
                }
            }
        }

        private void SlowDown()
        {
            slowTimer.Interval = 1000;
            slowTimer.Tick += SlowTimer_Tick;

            foreach (var fruit in balls)
            {
                fruit.timer.Interval = 60;
            }
            slowTimer.Start();          
        }

        private void SlowTimer_Tick(object? sender, EventArgs e)
        {
            slowSecondsRemain -= 1;

            if (slowSecondsRemain == 0)
            {
                foreach (var fruit in balls)
                {
                    fruit.timer.Interval = 20;
                }
                slowTimer.Stop();
                slowSecondsRemain = 2;
            }      
        }

        private void EndGame()
        {
            foreach (FruitBall fruitBall in balls)
            {
                fruitBall.Stop();
                timer.Enabled = false;
                startButton.Enabled = false;
            }
            MessageBox.Show("Игра окончена!");
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}