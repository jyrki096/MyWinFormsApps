using GeniyIdiot.Common;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class RemoveQuestionForm : Form
    {
        public RemoveQuestionForm()
        {
            InitializeComponent();
            var questions = QuestionsStorage.GetQuestions();
            int number = 1;
            int questionsAmount = questions.Count;
            foreach (var question in questions)
            {
                questionTable.Rows.Add(number.ToString(), question.Text);
                number++;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewCell oneCell in questionTable.SelectedCells)
            {
                if (oneCell.Selected)
                {

                    QuestionsStorage.Remove(oneCell.RowIndex);
                    questionTable.Rows.RemoveAt(oneCell.RowIndex);
                }
            }

        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
