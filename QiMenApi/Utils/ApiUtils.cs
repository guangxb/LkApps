using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace QiMenApi.Utils
{
    public class ApiUtils
    {
        public static string GetStreamAsString(Stream stream, Encoding encoding) {
            if (stream.CanSeek) {
                stream.Seek(0, System.IO.SeekOrigin.Begin);
            }
            stream.Position = 0;
            using (var reader = new StreamReader(stream, encoding)){
                return reader.ReadToEnd();
            }

            //方法2：
            //long len = stream.Length;
            //byte[] byts = new byte[len];
            //stream.Read(byts, 0, byts.Length);
            //string body = System.Text.Encoding.UTF8.GetString(byts);
        }
    }
}