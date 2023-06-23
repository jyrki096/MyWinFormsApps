using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(Form mainForm) : base(mainForm)
        {
            centerX = random.Next((int)LeftSide(), (int)RightSide());
            centerY = random.Next((int)UpSide(), (int)DownSide());
        }
    }
}
