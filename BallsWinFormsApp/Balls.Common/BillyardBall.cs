using Balls.Common;
using System.Drawing;
using System.Windows.Forms;

namespace BillyardBalls
{
    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> onHited;

        public BillyardBall(Form mainForm) : base(mainForm)
        {

        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                onHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                vx = -vx;
                onHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= UpSide())
            {
                vy = -vy;
                onHited.Invoke(this, new HitEventArgs(Side.Up));
            }

            if (centerY >= DownSide())
            {
                vy = -vy;
                onHited.Invoke(this, new HitEventArgs(Side.Down));
            }            
        }
    }
}
