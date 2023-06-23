namespace FrogsWinFormsApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPictureBox)
        {
            var distance = Math.Abs(clickedPictureBox.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {
                var location = clickedPictureBox.Location;
                clickedPictureBox.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                stepLabel.Text = (int.Parse(stepLabel.Text) + 1).ToString();
                if (EndGame())
                {
                    WinForm winForm = new WinForm(int.Parse(stepLabel.Text));
                    winForm.ShowDialog();
                    return;
                }
            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void showRulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель игры — расположить лягушек, которые смотрят влево, в левую часть, а остальных - в правую часть за минимальное количество перепрыгиваний.\n" +
                "Прыгать можно на листок, если он находится рядом или через 1 лягушку", "Правила");
        }

        private bool EndGame()
        {
            if (leftPictureBox1.Location.X >= 550 && leftPictureBox2.Location.X >= 550 && leftPictureBox3.Location.X >= 550 && leftPictureBox4.Location.X >= 550)
                return true;
            return false;
        }
    }
}