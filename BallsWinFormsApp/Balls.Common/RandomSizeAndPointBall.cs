using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form mainForm) : base(mainForm)
        {
            radius = random.Next(10, 40);
        }       
    }
}
