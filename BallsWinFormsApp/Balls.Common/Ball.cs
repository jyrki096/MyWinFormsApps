using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Balls.Common
{
    public class Ball
    {
        private Form mainForm;
        public Timer timer;

        protected float vx = 10;
        protected float vy = 10;

        public float centerX = 150;
        public float centerY = 150;

        protected Brush ballColor = Brushes.DarkBlue;
        public int radius = 20;

        Random random = new Random();
        
        public Ball(Form mainForm) 
        {
            centerX = mainForm.ClientSize.Width / 2;
            centerY = mainForm.ClientSize.Height;
            this.mainForm = mainForm;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Show()
        {
            Draw(ballColor);
        }

        public virtual void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            var brush = new SolidBrush(mainForm.BackColor);
            Draw(brush);
        }

        protected float UpSide()
        {
            return radius;
        }

        protected float RightSide()
        {
            return mainForm.ClientSize.Width - radius;
        } 

        protected float DownSide()
        {
            return mainForm.ClientSize.Height - radius;
        }

        protected float LeftSide()
        {
            return radius;
        }


        public bool IsCatched()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= UpSide() && centerY <= DownSide();
        }

        public bool Contains(int clickX, int clickY)
        {
            var dx = clickX - centerX;
            var dy = clickY - centerY;

            return Math.Pow(dx, 2) + Math.Pow(dy, 2) <= Math.Pow(radius, 2);
        }
      
        protected void Draw(Brush brush)
        {
            var graphics = mainForm.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public bool IsMoveable()
        {
            return timer.Enabled == true;
        }

        public List<float> GetCoordinates()
        {
            return new List<float> { centerX, centerY };
        }

        public Brush GetColor()
        {
            return ballColor;
        }

        public float GetSize()
        {
            return radius;
        }

        public void FlyUp()
        {

            vx = random.Next(-6, 6);
            vy = -6;
        }

        
    }
}
