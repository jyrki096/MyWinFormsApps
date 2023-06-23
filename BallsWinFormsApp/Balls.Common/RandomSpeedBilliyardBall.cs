using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillyardBalls
{
    public class RandomSpeedBilliyardBall : BillyardBall
    {
        public RandomSpeedBilliyardBall(Form mainForm) : base(mainForm)
        {
            var speed = random.Next(3, 10);
            vx = speed;
            vy = speed;
        }
    }
}
