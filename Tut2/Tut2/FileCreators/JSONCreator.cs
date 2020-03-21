using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using Tut2.Models;
using Tut2.Serializers;


namespace Tut2.FileCreators
{
    public class JSONCreator : IFileCreator
    {

        private static readonly string FileNameRegex = ".*\\.json";

        public University CreateUniversity(HashSet<Student> students)
        {
            return new JSONUniversity(students);
        }

        public bool IsPathCorrect(string path)
        {
            return  Regex.Match(path, FileNameRegex).Success;
        }

        public void Serialize(University toSerialize, string path)
        {
            if (!IsPathCorrect(path))
            {
                Console.WriteLine("Wroong");
                throw new ArgumentException();
            }
            else
            {
                FileStream writer = new FileStream(path, FileMode.Create);
                var serializer = new DataContractJsonSerializer(typeof(JSONUniversity));
                serializer.WriteObject(writer, toSerialize);
            }
        }
    }
}
