using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tut2.Models;

namespace Tut2
{
    class CSVFileReader
    {
        public static HashSet<Student> GetStudentsFromCSV(string path, ErrorLoger loger)
        {
            FileInfo info = new FileInfo(path);
            if (!info.Exists)
            {
                throw new FileNotFoundException();
            }
            string line = null;
            var list = new HashSet<Student>(new StudentsComparer()); 
            using (var stream = new StreamReader(info.OpenRead()))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    Student studentToAdd = Student.CreateFromCsvLine(line);
                    if (studentToAdd == null)
                    {
                        loger.AddMessage("Invalid input data line: " + line);
                        continue;
                    }
                    bool studentIsNotThere = list.Add(studentToAdd);
                    if (!studentIsNotThere)
                    {
                        loger.AddMessage("Duplicate input data line: " + line);
                    }
                }
            }
            return list;
        }
    }
}
