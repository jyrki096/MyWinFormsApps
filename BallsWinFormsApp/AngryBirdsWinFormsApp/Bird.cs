using Balls.Common;

public class Bird : MoveBall
{
    private float g = 0.0f;
    private float elastic = 0.4f;
    private Form mainForm;


    public Bird(Form form) : base(form)
    {
        ballColor = Brushes.DarkRed;
        mainForm = form;
        centerX = radius;
        centerY = form.ClientSize.Height - radius;
    }

    public void GetToPoint(int x, int y)
    {
        g = 2.0f;
        vx = x / 10;
        vy = -(mainForm.ClientSize.Height - y) / 10;
    }

    public override void Move()
    {
        base.Move();

        if (Math.Abs(vy) <= 0.25f && vy != 0 || !IsCatched())
        {
            Stop();
            Clear();
            ReturnToStandartPosition();
        }
    }

    protected override void Go()
    {
        centerX += vx;
        centerY += vy;

        vy += g;

        if (centerY >= DownSide())
        {
            vy = -Math.Abs(vy * elastic);
        }
    }

    public virtual void ReturnToStandartPosition()
    {
        g = 0.0f;

        vx = 0;
        vy = 0;

        centerX = 2 * radius;
        centerY = mainForm.ClientSize.Height - 2 * radius;

        Start();
    }
}
