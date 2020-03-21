using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Tut2.Models;

namespace Tut2.Serializers
{
    public class XMLCreator : IFileCreator
    {
        private static readonly string FileNameRegex = ".*\\.xml";

        public bool IsPathCorrect(string path)
        {
            return Regex.Match(path, FileNameRegex).Success;
        }

        public void Serialize(HashSet<Student> list, string path)
        {
            if (!IsPathCorrect(path))
            {
                throw new ArgumentException();
            }
            else
            {
                FileStream writer = new FileStream(path, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>), new XmlRootAttribute("univeristy"));
                serializer.Serialize(writer, list);
            }
            
        }
    }
}
