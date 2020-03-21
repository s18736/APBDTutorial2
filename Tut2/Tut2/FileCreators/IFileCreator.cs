using System;
using System.Collections.Generic;
using System.Text;
using Tut2.Models;

namespace Tut2.Serializers
{
    public interface IFileCreator
    {
        void Serialize(University toSerialize, string path);
        bool IsPathCorrect(string path);
        University CreateUniversity(HashSet<Student> students);
    }
}
