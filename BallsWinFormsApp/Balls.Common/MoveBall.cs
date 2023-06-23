using Timer = System.Windows.Forms.Timer;
using System.Windows.Forms;


namespace Balls.Common
{
     public class MoveBall : RandomPointBall
     { 
        public MoveBall(Form mainForm) : base(mainForm)
        {
            vx *= SetDirection();
            vy *= SetDirection();
        }

        public int SetDirection()
        {
            var directionsValues = new int[2] { -1, 1 };
            return directionsValues[random.Next(0, 2)];
        }
     }
}
