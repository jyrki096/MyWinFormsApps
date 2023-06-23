

namespace _2048WinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public string Name = "Неизвестно";
        public int MatrixSize;
        public int MainFormWidth;
        public int MainFormHeight;
        private bool isStartButtonCliked = false;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            playerNameTextBox.Focus();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isStartButtonCliked = true;
            Name = playerNameTextBox.Text;

            if (Name == "")
            {
                MessageBox.Show("Введите имя!");
            }
            else
            {
                SelectSize();
                Close();
            }
        }

        private void SelectSize()
        {

            if (fourOnFourRadio.Checked)
                MatrixSize = 4;

            if (sixOnSixRadio.Checked)
                MatrixSize = 6;

            if (eightOnEigthRadio.Checked)
                MatrixSize = 8;

            if (tenOnTenRadio.Checked)
                MatrixSize = 10;
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isStartButtonCliked && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из игры?", "Выход из приложения", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
