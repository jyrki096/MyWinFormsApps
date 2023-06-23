using System.Windows.Forms;
using System.Drawing;
using Balls.Common;


namespace SalutWinFormsApp
{
    public partial class mainForm : Form
    {
        private Ball ball;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                var salutBall = new SalutBall(this, e.X, e.Y);
                salutBall.Start();
            }
        }

        private void salutStartButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ball = new Ball(this);
            ball.FlyUp();
            ball.Start();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ball.Show();

            if (ball.GetCoordinates()[1] < ClientSize.Height / 4)
            {
                ball.Stop();
                ball.Clear();
                timer.Enabled = false;

                for (int i = 0; i < 30; i++)
                {
                    var salutBall = new SalutBall(this, ball.GetCoordinates()[0], ball.GetCoordinates()[1]);
                    salutBall.Start();
                }
                
            }
        }
    }
}