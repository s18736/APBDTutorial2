﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tut2.Models
{
    public class Studies
    {
        [XmlElement(elementName: "name")]
        public string name { get; set; }

        [XmlElement(elementName: "mode")]
        public string mode { get; set; }
    }
}
