using System;
using System.Diagnostics;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");

            string name = Console.ReadLine();

            while (true)
            {
                
                var user = new User(name);
                var game = new Game(user);

                Console.WriteLine("Внимание!!! Ответ на каждый вопрос не должен превышать 10 секунд. В противном случае ответ не будет засчитан.");
                while (!game.End())
                {

                    var currentQuestion = game.GetNextQuestion();
                    
                    Console.WriteLine(game.GetQuestionNumberText());
                    
                    Console.WriteLine(currentQuestion.Text);
                    var timer = new Stopwatch();
                    timer.Start();
                    var userAnswer = GetNum();
                    timer.Stop();
                    if (timer.ElapsedMilliseconds <= 10000)
                    {
                        Console.WriteLine("Ответ принят");
                        game.AcceptAnswer(userAnswer.ToString());
                    }
                    else
                    {
                        game.DeclineAnswer();
                        Console.WriteLine("Время вышло");
                    }
                }


                var result = game.CalculateDiagnose();

                Console.WriteLine(result);

                Console.WriteLine($"{user.Name}, хотите посмотреть всю статистику? Введите да или нет");

                if (CheckUserChoice())
                {
                    ShowUsersResults();
                }

                Console.WriteLine($"{user.Name}, хотите добавить новый вопрос? Введите да или нет");

                if (CheckUserChoice())
                {
                    AddNewQuestions();
                }

                Console.WriteLine($"{user.Name}, хотите удалить существующий вопрос? Введите да или нет");

                if (CheckUserChoice())
                {
                    RemoveQuestion();
                }

                Console.WriteLine($"{name}, хотите пройти тест еще раз? Введите да или нет");

                if (!CheckUserChoice())
                    break;
            }

        }
        

        static void RemoveQuestion()
        {
            var setOfQuestions = QuestionsStorage.GetQuestions();


            for (int i = 0; i < setOfQuestions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {setOfQuestions[i].Text}");
            }

            Console.WriteLine("Введите номер, удаляемого вопроса");

            int questionIndex = GetNum() - 1;

            while (questionIndex < 0 || questionIndex > setOfQuestions.Count - 1)
            {
                Console.WriteLine($"Введите корректный номер вопроса от 1 до {setOfQuestions.Count}");
                questionIndex = GetNum() - 1;
            }


            QuestionsStorage.Remove(questionIndex);
            Console.WriteLine("Вопрос успешно удалён");
        }

        static void AddNewQuestions()
        {
            Console.WriteLine("Введите вопрос");
            string question = Console.ReadLine();
            Console.WriteLine("Введите ответ");
            string answer = GetNum().ToString();
            QuestionsStorage.SaveNewQuestion(new Question(question, answer));
            Console.WriteLine("Новый вопрос успешно добавлен");
        }

        static int GetNum()
        {
            int number;
            while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }

            return number;
        }
        

        static bool CheckUserChoice()
        {
            string answer = Console.ReadLine().ToLower();

            while (answer != "да" && answer != "нет")
            {
                Console.WriteLine("Введите в ответе да или нет");
                answer = Console.ReadLine().ToLower();
            }

            return answer == "да";
        }

        static void ShowUsersResults()
        {
            var results = UsersResultStorage.GetUsersResults();
            string outputFormat = "|| {0,-27} || {1,-27} || {2,-27} ||";
            Console.WriteLine(outputFormat, "Имя:", "Количество верных решений:", "Диагноз:");

            foreach (var user in results)
            {
                Console.WriteLine(outputFormat, user.Name, user.CountRightAnswers, user.Diagnosis);
            }
        }


    }
}
