using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Tut2.Models;

namespace Tut2.Serializers
{
    public class XMLCreator : IFileCreator
    {
        public void Serialize(HashSet<Student> list, string path)
        {
            FileStream writer = new FileStream(path, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>), new XmlRootAttribute("univeristy"));
            serializer.Serialize(writer, list);
        }
    }
}
