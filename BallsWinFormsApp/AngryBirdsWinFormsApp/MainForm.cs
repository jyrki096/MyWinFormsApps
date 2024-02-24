namespace AngryBirdsWinFormsApp
{
    public partial class mainForm : Form
    {
        private Bird bird;
        private Pig pig;
        private int score;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            bird = new Bird(this);
            pig = new Pig(this);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            timer.Enabled = true;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            bird.GetToPoint(e.X, e.Y);
            bird.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bird.Show();
            pig.Show();
            CheckTheHit();
        }

        public void CheckTheHit()
        {
            var dx = bird.centerX - pig.centerX;
            var dy = bird.centerY - pig.centerY;

            if (dx * dx + dy * dy <= (bird.radius + pig.radius) * (bird.radius + pig.radius))
            {
                pig.Clear();
                pig = new Pig(this);
                score += 1;
                scoreLabel.Text = score.ToString();
            }
        }
    }
}