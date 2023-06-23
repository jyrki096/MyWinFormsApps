using Newtonsoft.Json;


namespace _2048WinFormsApp
{
    public class PlayersResultsStorage
    {

        private static string path = "results.json";

        public static void SavePlayerResult(Player player)
        {
            var playersResults = GetPlayersResults();
            playersResults.Add(player);

            Save(playersResults);
        }

        public static List<Player> GetPlayersResults()
        {
            if (!FileSystem.Exists(path))
            {
                return new List<Player>();
            }

            var fileData = FileSystem.Get(path);
            var playersResults = JsonConvert.DeserializeObject<List<Player>>(fileData);

            return playersResults;
        }

        public static void Save(List<Player> players)
        {
            var jsonData = JsonConvert.SerializeObject(players, Formatting.Indented);
            FileSystem.Replace(path, jsonData);
        }

        public static int GetBestScore()
        {
            var results = GetPlayersResults().OrderByDescending(x => x.Score);

            if (results.Count() == 0)
                return 0;

            return results.ElementAt(0).Score;
        }
    }
}