using System;
using System.Collections.Generic;
using System.IO;

namespace FindMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = FileReader.GetPath(args);
                       
            var textFromFile = FileReader.GetDataFromFileBy(path);

            List<int> badLinesNumberList = new List<int>();

            Console.WriteLine("НОМЕР СТРОКИ С МАКСИМАЛЬНОЙ СУММОЙ: {0}", FileParser.GetNumberOfMaxLineIn(textFromFile, badLinesNumberList));

            Console.Write ("СПИСОК БРАКОВАННЫХ СТРОК: ");
            foreach(var number in badLinesNumberList)
                Console.Write(number + "  ");

            Console.ReadKey();


        }
    }
}
