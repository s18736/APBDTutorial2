using System;
using System.Collections.Generic;
using System.Text;

namespace Tut2.Models
{
    public class JSONUniversity : University
    {
        public HashSet<Student> Students { get; set; }

        public JSONUniversity()
        {

        }

        public JSONUniversity(HashSet<Student> students)
        {
            this.Students = students;
        }
    }
}
