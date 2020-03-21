using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tut2.Models
{
    
    public class Student
    {
        [XmlAttribute(attributeName: "index")]
        public string Index { get; set; }

        [XmlElement(elementName: "fname")]
        public string Fname { get; set; }
        [XmlElement(elementName: "lname")]
        public string Lname { get; set; }
        [XmlElement(elementName: "birthdate")]
        public string Birthdate { get; set; }
        [XmlElement(elementName: "email")]
        public string Email { get; set; }
        [XmlElement(elementName: "mothersName")]
        public string MothersName { get; set; }
        [XmlElement(elementName: "fathersName")]
        public string FathersName { get; set; }
        [XmlElement(elementName: "studies")]
        public Studies Studies { get; set; }

        public static Student CreateFromCsvLine(string csvLine)
        {
            string[] words = csvLine.Split(",");
            if (words.Length != 9)
            {
                return null;
            }
            Student student = new Student();
            foreach(string word in words)
            {
                if (word == null || word.Length == 0)
                {
                    return null;
                }
            }
            student.Fname = words[0];
            student.Lname = words[1];
            student.Studies = new Studies();
            student.Studies.name = words[2];
            student.Studies.mode = words[3];
            student.Index = words[4];
            student.Birthdate = words[5];
            student.Email = words[6];
            student.MothersName = words[7];
            student.FathersName = words[8];
            return student;
        }
    }

    
}

