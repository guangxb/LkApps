using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Request
    {
        public string System { get; set; }
        public string SecurityCode { get; set; }
        public PatientBasicInfo PatientInfo { get; set; }
    }
}
