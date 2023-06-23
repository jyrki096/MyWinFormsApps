using Balls.Common;
using System.Windows.Forms;

public class SalutBall : RandomMoveBall
{
    private float g = 2.2f;

    public SalutBall(Form form, float centerX, float centerY) : base(form)
    {
        radius = 10;
        this.centerX = centerX;
        this.centerY = centerY;
        vy = -Math.Abs(vy);
    }

    protected override void Go()
    {
        base.Go();
        vy += g;
    }
    
}
