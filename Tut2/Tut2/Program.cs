using System;
using System.Collections.Generic;
using System.IO;
using Tut2.FileCreators;
using Tut2.Models;
using Tut2.Serializers;

namespace Tut2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = args[0];
            var outputPath = args[1];
            var mode = args[2];
            IFileCreator creator = GetFileCreator(mode);
            ErrorLoger loger = new ErrorLoger();
            HashSet<Student> students = new HashSet<Student>();
            try
            {
                students = CSVFileReader.GetStudentsFromCSV(path);
                
            } catch (FileNotFoundException exc)
            {
                loger.AddMessage("File not found!");
            } 

            try
            {
                creator.Serialize(students, outputPath);
            }
            catch (ArgumentException exc)
            {
                loger.AddMessage("Wrong file name!");
            }
            
            loger.PrintMessages(); //writing this file
            //Console.ReadKey();   //to stop the program
        }

        public static IFileCreator GetFileCreator(string mode)
        {
            mode = mode.ToUpper();
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
