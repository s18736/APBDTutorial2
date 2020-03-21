using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tut2.Models
{
    public class StudentsList
    {
        [XmlElement(elementName: "student")]
        public HashSet<Student> Students { get; set; }

        public StudentsList()
        {

        }

        public StudentsList(HashSet<Student> students)
        {
            this.Students = students;
        }

    }
}
