using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Request patientIn = new Request();
            patientIn.System = "HIS";
            patientIn.SecurityCode = "HIS5";

            PatientBasicInfo basicInfo = new PatientBasicInfo();
            basicInfo.PatientNo = "1234";
            basicInfo.PatientName = "测试";
            patientIn.PatientInfo = basicInfo;
            List<string> list = new List<string>();
            list.Add("123");
            list.Add("234");
            basicInfo.Ss = list;

            //序列化
            string strxml = XmlSerializeHelper.XmlSerialize<Request>(patientIn);
            Console.WriteLine(strxml);
            Console.ReadKey();
        }
    }
}
