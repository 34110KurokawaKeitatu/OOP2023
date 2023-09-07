﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02 {
    [XmlRoot("novelist")]
    [DataContract]
    public class Novelist {
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }

        [XmlArrayItem("masterpieces")]
        [XmlArrayItem("titel", typeof(string))]
        [DataMember(Name = "mmasterpieces")]
        public string[] Masterpieces { get; set; }
    }
}
