using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Tut2.Models;
using Tut2.Serializers;


namespace Tut2.FileCreators
{
    public class JSONCreator : IFileCreator
    {
        public void Serialize(HashSet<Student> hashSet, string path)
        {
            FileStream writer = new FileStream(path, FileMode.Create);
            var serializer = new DataContractJsonSerializer(typeof(HashSet<Student>));
            serializer.WriteObject(writer, hashSet);
        }
    }
}
