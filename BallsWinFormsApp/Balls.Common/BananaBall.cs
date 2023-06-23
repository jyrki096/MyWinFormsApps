using System.Windows.Forms;
using System.Drawing;


public class BananaBall : FruitBall
{
    public BananaBall(Form form) : base(form)
    {
        ballColor = new SolidBrush(Color.Yellow);
    }
}

