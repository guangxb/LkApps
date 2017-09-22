using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Top.Api.Util
{
    public class XmlSerializeHelper
    {
        public static string XmlSerialize<T>(T obj)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.Encoding = new UTF8Encoding(false); 
            //settings.IndentChars = "    ";
            //settings.NewLineChars = "\r\n";
            //settings.Encoding = Encoding.UTF8;

            using (System.IO.MemoryStream mem = new MemoryStream())
            using (System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create(mem, settings))
            {
                Type t = obj.GetType();
                XmlSerializer serializer = new XmlSerializer(t);

                XmlSerializerNamespaces xns = new XmlSerializerNamespaces();

                foreach (var attribute in t.GetCustomAttributes(true))
                {
                    var xmlRootAttribute = attribute as XmlRootAttribute;
                    if (xmlRootAttribute != null)
                    {
                        xns.Add(string.Empty, xmlRootAttribute.Namespace);
                        //xns.Add(string.Empty, string.Empty);
                    }
                }

                if (xns.Count == 0)
                {
                    xns.Add(string.Empty, string.Empty);
                }

                serializer.Serialize(xmlWriter, obj, xns);
                return Encoding.UTF8.GetString(mem.ToArray());
            }
        }
    }
}
