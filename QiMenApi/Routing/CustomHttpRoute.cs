using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http.Routing;
using System.Web.Routing;

namespace QiMenApi.Routing
{
    public class CustomHttpRoute : HttpRoute
    {
        public override IHttpRouteData GetRouteData(string virtualPathRoot, HttpRequestMessage request)
        {
            //request.RequestUri = new Uri("http://localhost:9090/api/ItemsSynchronize?method=123");
            string urlPara = request.RequestUri.Query.ToLower();
            //int i = para.IndexOf("taobao.qimen.");
            //if (i >= 0) {
            //    para = para.Substring(i);
            //    if (para.IndexOf("&") > 0) {
            //        para = para.Remove(para.IndexOf("&"));
            //    }
            //}
            string controllerStr = "";
            string pattern;
            if (urlPara.Contains("method=taobao.qimen."))
            {
                pattern = @"taobao.qimen.([A-Za-z0-9_.]+)";
            }
            else {
                pattern = @"method=([A-Za-z0-9_.]+)";
            }
            
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            Match match = rgx.Match(urlPara);
            if (match.Success)
            {
                Group g = match.Groups[1];
                controllerStr = g.Value.Replace(".","");
            }

            if (!string.IsNullOrEmpty(controllerStr))
            {
                var data = new HttpRouteData(this);
                data.Values.Add("controller", controllerStr);
                return data;
            }
            else
            {
                return base.GetRouteData(virtualPathRoot, request);
            }
            //if (matches.Count > 0) {
            //    string re = matches[1].Value;
            //}
            //return match.Value;
            //para.Substring();

            //return base.GetRouteData(virtualPathRoot, request);

            //var data = new HttpRouteData(this);//声明一个RouteData，添加相应的路由值
            //data.Values.Add("controller", "ItemsSynchronize");
            //data.Values.Add("action", "ShowCategory");
            //data.Values.Add("id", category.CategoeyID);
        }



        public override IHttpVirtualPathData GetVirtualPath(HttpRequestMessage request, IDictionary<string, object> values)
        {
            return base.GetVirtualPath(request, values);
        }

        //public HttpRouteData GetRouteData(string virtualPathRoot, HttpRequestMessage request)
        //{
        //    request.RequestUri = new Uri("");
        //    var data = new HttpRouteData(this);
        //    data.Values.Add();
        //    return data;
        //}

        //public IHttpVirtualPathData GetVirtualPath(HttpRequestMessage request, IDictionary<string, object> values)
        //{
        //    throw new NotImplementedException();
        //}
    }
}