using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationRadore
{
    [Serializable]
    public class Employee
    {
        public string name {  get; set; }
        public string phone { get; set; }
        public DateTime dob { get; set; }
        public string department { get; set; }
        public int salary { get; set; }

        [NonSerialized]
        [XmlIgnore] // Serialize edilmemesi için NonSerialized ile kullanmamız gerekli!!!
        public string additionalInfo;


    }
}
