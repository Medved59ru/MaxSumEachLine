using System;
using System.Collections.Generic;
using System.IO;

namespace FindMaxSum
{
    public class FileReader
    {
        public static string GetPath(string[] args)
        {
            string path = "";
            try
            {
                path = args[0];
            }
            catch
            {
                if (string.IsNullOrEmpty(path))
                {
                    path = ReadPathFromConsole();
                    path = CheckThe(path);
                }
            }
            return path;
        }

        public static string CheckThe(string path)
        {
            while (!File.Exists(path))
            {
                path = ReadPathFromConsole();
            }
            return path;
        }

        public static string[] GetDataFromFileBy(string path)
        {
            List<string> textByLines = new List<string>();

            using (StreamReader file = new StreamReader(path))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    textByLines.Add(line);
                }
                file.Close();
            }

            return textByLines.ToArray();
        }
        private static string ReadPathFromConsole()
        {
            Console.Write("Введите путь к файлу: ");
            return Console.ReadLine();
        }
    }
}
