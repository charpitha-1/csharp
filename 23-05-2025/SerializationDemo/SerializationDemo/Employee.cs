using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute("EmpId")] //name of the attribute
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [XmlIgnore] //ignores the password in xml file
        public string Password { get; set; }
        [XmlArray]
        [XmlArrayItem(elementName:"Phoneentry")] //the name is phone entry default it is string
        public string[] Phones { get; set; }
    }
}
