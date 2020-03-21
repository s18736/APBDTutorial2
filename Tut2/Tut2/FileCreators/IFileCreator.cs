using System;
using System.Collections.Generic;
using System.Text;
using Tut2.Models;

namespace Tut2.Serializers
{
    public interface IFileCreator
    {
        void Serialize(HashSet<Student> hashSet, string path);
    }
}
