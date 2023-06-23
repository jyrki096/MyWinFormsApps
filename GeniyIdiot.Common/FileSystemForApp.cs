using System.Text;


namespace GeniyIdiot.Common
{
    public class FileSystemForApp
    {
        public static void SaveData(string path, string data)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static void ReplaceData(string path, string data)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static string GetData(string filePath)
        {
            var reader = new StreamReader(filePath, Encoding.UTF8);
            var data = reader.ReadToEnd();
            reader.Close();
            return data;
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static void Clear(string path)
        {
            File.WriteAllText(path, string.Empty);
        }
    }
}
