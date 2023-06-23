using Balls.Common;
using System.Windows.Forms;
using System.Drawing;


public class FruitBall : RandomMoveBall
{
    private float g = 1.2f;
    private Form mainForm;

    public FruitBall(Form mainForm) : base(mainForm)
    {
        this.mainForm = mainForm;
        ballColor = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
        radius = 20;
        vy = (float)random.NextDouble() * -6 - 7;
        centerX = random.Next(radius, mainForm.ClientSize.Width - radius);
        centerY = mainForm.ClientSize.Height + radius;
            
    }

    protected override void Go()
    {
        base.Go();
        if (centerY < mainForm.ClientSize.Height / 3)
            vy += g;

        if (centerY > DownSide() + 2 * radius)
            Stop();
    }

}
