

namespace GeniyIdiot.Common
{
    public class Game
    {
        public List<Question> Questions;
        Question currentQuestion;
        public User User;
        int questionsAmount;
        public int QuestionNumber;

        public Game(User user) 
        { 
            this.User = user;
            Questions = QuestionsStorage.GetQuestions();
            questionsAmount = Questions.Count;
        }

        public Question GetNextQuestion()
        {
            var range = new Random();
            int randomIndex = range.Next(Questions.Count);
            currentQuestion = Questions[randomIndex];
            QuestionNumber++;

            return currentQuestion;
        }

        public string GetQuestionNumberText()
        {
            return $"Вопрос №{QuestionNumber}";
        }

        public void AcceptAnswer(string userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                User.AcceptRightAnswer();
            }

            Questions.Remove(currentQuestion);
        }

        public void DeclineAnswer()
        {      
            Questions.Remove(currentQuestion);
        }

        public bool End()
        {
            return Questions.Count == 0;
        }

        public string CalculateDiagnose()
        {
            DiagnosisCalculator.GetDiagnosis(User, questionsAmount);
            UsersResultStorage.SaveUserResult(User);
            return $"{User.Name}, ваш диагноз {User.Diagnosis}";
        }
    }
}
