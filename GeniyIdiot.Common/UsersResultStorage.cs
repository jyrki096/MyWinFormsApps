using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class UsersResultStorage
    {
        private static string path = "statistic.json";

        public static void SaveUserResult(User user)
        {
            var userResults = GetUsersResults();
            userResults.Add(user);

            Save(userResults);
        }

        public static List<User> GetUsersResults()
        {
            if (!FileSystemForApp.Exists(path))
            {
                return new List<User>();
            }

            var fileData = FileSystemForApp.GetData(path);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return usersResults;
        }

        public static void Save(List<User> users)
        {
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileSystemForApp.ReplaceData(path, jsonData);
        }
    

        
    }
}