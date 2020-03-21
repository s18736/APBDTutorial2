using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tut2.Models
{
    public class XMLUniversity : University
    {
        [XmlElement(elementName: "students")]
        public StudentsList Students { get; set; }

        public XMLUniversity()
        {

        }

        public XMLUniversity(HashSet<Student> students)
        {
            Students = new StudentsList(students);
        }
    }
}
