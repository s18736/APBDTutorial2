using System;
using System.Collections.Generic;
using Tut2.FileCreators;
using Tut2.Models;
using Tut2.Serializers;

namespace Tut2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"Data/dane.csv";
            var outputPath = @"output.json";
            var mode = "JSON";
            IFileCreator creator = GetFileCreator(mode);
            HashSet<Student> students = CSVFileReader.GetStudentsFromCSV(path);
            creator.Serialize(students, outputPath);

        }

        public static IFileCreator GetFileCreator(string mode)
        {
            if (mode == "JSON")
            {
                return new JSONCreator();
            }
            if (mode == "XML")
            {
                return new XMLCreator();
            }
            Console.Write("Unknown mode! Creating XML!");
            return new XMLCreator();
        }
    }
}
