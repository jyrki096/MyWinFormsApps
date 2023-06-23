
using System.Text;

namespace _2048WinFormsApp
{
    public class FileSystem
    {
        public static void Append(string path, string data)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static void Replace(string path, string data)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static string Get(string filePath)
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