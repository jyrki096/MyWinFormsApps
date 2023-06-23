using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var isValidAnswer = InputValidator.TryParseToNumber(inputAnswerTextBox.Text, out int number, out string errorMessage);

            if (inputQuestionTextBox.Text == "")
                MessageBox.Show("Введите вопрос!!!");

            if (isValidAnswer)
            {
                QuestionsStorage.SaveNewQuestion(new Question(inputQuestionTextBox.Text, inputAnswerTextBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
