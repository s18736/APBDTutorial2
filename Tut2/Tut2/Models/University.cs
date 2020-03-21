using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Tut2.Models
{
    public class University
    {
        [XmlAttribute(attributeName: "createdAt")]
        public string CreatedAt { get; set; }
        [XmlAttribute(attributeName: "author")]
        public string Author { get; set; }
        

        public University()
        {
            this.Author = "Maciej Malewicz";
            this.CreatedAt = DateTime.Now.ToShortDateString();
        }


    }
}
