using System.Windows.Forms;

namespace Balls.Common
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            this.centerX = x - radius / 2;
            this.centerY = y - radius / 2;
        }
    }
}
