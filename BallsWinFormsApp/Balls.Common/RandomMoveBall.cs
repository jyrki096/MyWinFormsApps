using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(Form mainForm) : base(mainForm)
        {
            vx = (float)random.NextDouble() * 15 - 5;
            vy = (float)random.NextDouble() * 15 - 5;
        }
    }
}
