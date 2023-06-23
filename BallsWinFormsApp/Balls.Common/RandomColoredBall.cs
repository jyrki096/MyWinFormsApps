using Balls.Common;
using BillyardBalls;
using System.Drawing;
using System.Windows.Forms;

namespace Diffusion
{
    public class RandomColoredBall : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> onHited;
        private Form mainForm;

        public RandomColoredBall(Form mainForm, Brush color, Side side) : base(mainForm)
        {
            ballColor = color;
            this.mainForm = mainForm;
            ChooseSide(side);
        }

        protected override void Go()
        {
            base.Go();


            if (ballColor == Brushes.DarkBlue)
            {
                if (centerX <= LeftSide())
                {
                    centerX = LeftSide();
                    vx = -vx;
                    onHited.Invoke(this, new HitEventArgs(Side.LeftBlue));
                }

                if (centerX >= RightSide())
                {
                    centerX = RightSide();
                    vx = -vx;
                    onHited.Invoke(this, new HitEventArgs(Side.RightBlue));
                }

                if (centerY <= UpSide())
                {
                    centerY = UpSide();
                    vy = -vy;
                    onHited.Invoke(this, new HitEventArgs(Side.UpBlue));
                }

                if (centerY >= DownSide())
                {
                    centerY = DownSide();
                    vy = -vy;
                    onHited.Invoke(this, new HitEventArgs(Side.DownBlue));
                }
            }

            if (ballColor == Brushes.DarkRed)
            {
                if (centerX <= LeftSide())
                {
                    vx = -vx;
                    onHited.Invoke(this, new HitEventArgs(Side.LeftRed));
                }

                if (centerX >= RightSide())
                {
                    vx = -vx;
                    onHited.Invoke(this, new HitEventArgs(Side.RightRed));
                }

                if (centerY <= UpSide())
                {
                    vy = -vy;
                    onHited.Invoke(this, new HitEventArgs(Side.UpRed));
                }

                if (centerY >= DownSide())
                {
                    vy = -vy;
                    onHited.Invoke(this, new HitEventArgs(Side.DownRed));
                }
            }

        }

        private void ChooseSide(Side side)
        {
            switch (side)
            {
                case Side.Left:
                    centerX = (float)random.Next((int)LeftSide(), mainForm.ClientSize.Width / 2 - (int)radius);
                    centerY = (float)random.Next((int)UpSide(), (int)DownSide());
                    break;
                
                case Side.Right:
                    centerX = random.Next(mainForm.ClientSize.Width / 2 + (int)radius, (int)RightSide());
                    centerY = random.Next((int)UpSide(), (int)DownSide());
                    break;
            }
        }

    }
}