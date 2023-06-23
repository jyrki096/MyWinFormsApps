using System.Drawing;
using System.Windows.Forms;


public class BombBall : FruitBall
{
    public BombBall(Form form) : base(form)
    {
        ballColor = Brushes.Black;
    }
}
