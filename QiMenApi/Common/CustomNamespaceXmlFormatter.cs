using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Common
{
    public class CustomNamespaceXmlFormatter : XmlMediaTypeFormatter
    {
        //public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        //{
        //    var xns = new XmlSerializerNamespaces();
        //    foreach (var attribute in type.GetCustomAttributes(true))
        //    {
        //        var xmlRootAttribute = attribute as XmlRootAttribute;
        //        if (xmlRootAttribute != null)
        //        {
        //            xns.Add(string.Empty, xmlRootAttribute.Namespace.ToLower());
        //        }
        //    }

        //    if (xns.Count == 0)
        //    {
        //        xns.Add(string.Empty, string.Empty);
        //    }
        //    return base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
        //}
        //public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext, CancellationToken cancellationToken)
        //{

        //    var xns = new XmlSerializerNamespaces();
        //    foreach (var attribute in type.GetCustomAttributes(true))
        //    {
        //        var xmlRootAttribute = attribute as XmlRootAttribute;
        //        if (xmlRootAttribute != null)
        //        {
        //            xns.Add(string.Empty, xmlRootAttribute.Namespace.ToLower());
        //        }
        //    }
        //    if (xns.Count == 0)
        //    {
        //        xns.Add(string.Empty, string.Empty);
        //    }
        //    return base.WriteToStreamAsync(type, value, writeStream, content, transportContext, cancellationToken);
        //}

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext, CancellationToken cancellationToken)
        {
            try
            {
                var xns = new XmlSerializerNamespaces();
                foreach (var attribute in type.GetCustomAttributes(true))
                {
                    var xmlRootAttribute = attribute as XmlRootAttribute;
                    if (xmlRootAttribute != null)
                    {
                        //xns.Add(string.Empty, xmlRootAttribute.Namespace);
                        xns.Add(string.Empty, string.Empty);
                    }
                }

                if (xns.Count == 0)
                {
                    xns.Add(string.Empty, string.Empty);
                }
                var task = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        var serializer = new XmlSerializer(type);
                        serializer.Serialize(writeStream, value, xns);
                    }
                    catch {
                        base.WriteToStreamAsync(type, value, writeStream, content, transportContext, cancellationToken);
                    }
                });

                return task;
            }
            catch
            {
                return base.WriteToStreamAsync(type, value, writeStream, content, transportContext,cancellationToken);
            }
        }

    }
}