using System;
using System.Collections.Generic;
using System.Text;
using Tut2.Models;

namespace Tut2
{
    class StudentsComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return String.Equals($"{x.Fname}", $"{y.Fname}");
        }

        public int GetHashCode(Student obj)
        {
            return obj.Fname.GetHashCode();
        }
    }
}
