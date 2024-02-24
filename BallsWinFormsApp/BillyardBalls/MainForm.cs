namespace BillyardBalls
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSpeedBilliyardBall(this);
                ball.onHited += Ball_onHited;
                ball.Start();
            }
        }

        private void Ball_onHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Up:
                    upLabel.Text = (int.Parse(upLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (int.Parse(downLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}