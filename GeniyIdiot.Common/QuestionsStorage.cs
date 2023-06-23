using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string path = "questions.json";

        public static List<Question> GetQuestions()
        {

            if (!FileSystemForApp.Exists(path))
            {
                var defaultSetOfQuestions = new List<Question>()
                {
                    new Question("Сколько будет два плюс два умноженное на два?", "6"),
                    new Question("Бревно нужно распилить на 10 частей.Сколько распилов нужно сделать?", "9"),
                    new Question("На двух руках 10 пальцев.Сколько пальцев на 5 руках?", "25"),
                    new Question("Укол делают каждые полчаса.Сколько нужно минут, чтобы сделать три укола?", "60"),
                    new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", "3")
                };
                SaveInJson(defaultSetOfQuestions);
            }
 
            var questionsData = FileSystemForApp.GetData(path);
            var setOfQuestions = JsonConvert.DeserializeObject<List<Question>>(questionsData);
            return setOfQuestions;
        }

        public static void SaveNewQuestion(Question question)
        {
            var setOfQuestions = GetQuestions();
            setOfQuestions.Add(question);
            SaveInJson(setOfQuestions);  
        }

        public static void Remove(int index)
        {
            var setOfQuestions = GetQuestions();
            FileSystemForApp.Clear(path);
            setOfQuestions.RemoveAt(index);
            SaveInJson(setOfQuestions);
        }

        public static void SaveInJson(List<Question> data)
        {
            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            FileSystemForApp.ReplaceData(path, jsonData);
        }

    }
}