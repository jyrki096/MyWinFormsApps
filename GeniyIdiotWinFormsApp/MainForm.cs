using GeniyIdiot.Common;



namespace GeniyIdiotWinFormsApp
{
    public partial class mainForm : Form
    {
        Game game;
        private int timeLeft = 10;
        private User user;

        public mainForm()
        {
            InitializeComponent();
        }

        

        private void mainForm_Load(object sender, EventArgs e)
        {
            var userNameForm = new UserNameForm();
            user = new User(userNameForm.UserName);
            game = new Game(user);
            userNameForm.ShowDialog();
            ShowNextQuestion();
        }

        public void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionNumberLabel.Text = game.GetQuestionNumberText();
            questionTextLabel.Text = currentQuestion.Text;
            userTextBox.Focus();
            timeLeft = 10;
            timer1.Start();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var isValidAnswer = InputValidator.TryParseToNumber(userTextBox.Text, out int number, out string errorMessage);


            if (isValidAnswer)
            {
                var userAnswer = userTextBox.Text;
                game.AcceptAnswer(userAnswer);
                userTextBox.Clear();

                if (game.End())
                {
                    var result = game.CalculateDiagnose();
                    timer1.Stop();
                    MessageBox.Show(result);
                    return;
                }
                timer1.Stop();
                ShowNextQuestion();
            }
            else
            {
                MessageBox.Show(errorMessage);
                userTextBox.Clear();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Вы уверены, что хотите начать новую игру?",
             "Новая игра",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Restart();
            }
            
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UsersResultsForm();
            userResultsForm.ShowDialog();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var addNewQuestionForm = new AddNewQuestionForm();
            addNewQuestionForm.ShowDialog();
        }

        private void questionRemoveButton_Click(object sender, EventArgs e)
        {
            var removeForm = new RemoveQuestionForm();
            removeForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Вы уверены, что хотите выйти?",
             "Выход",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timerText.Text = $"Осталось времени: {timeLeft} секунд";
            timeLeft -= 1;

            if (timeLeft == -1)
            {
                timer1.Stop();
                game.DeclineAnswer();

                if (game.End())
                {
                    var result = game.CalculateDiagnose();

                    MessageBox.Show(result);
                    return;
                }

                ShowNextQuestion();
            }


        }

        private void retry_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Вы уверены, что хотите начать сначала?",
             "Начать заново",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes) 
            {
                timer1.Stop();
                user.CountRightAnswers = 0;
                game = new Game(user);
                ShowNextQuestion();
            }
            
        }
        
    }
}