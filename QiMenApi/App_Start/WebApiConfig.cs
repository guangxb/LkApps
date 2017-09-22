using QiMenApi.Common;
using QiMenApi.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace QiMenApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            config.Routes.Add("QiMen",new CustomHttpRoute());//分类规则

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "QiMenApi", id = RouteParameter.Optional }
            );

            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            ////config.Formatters.Clear();
            config.Formatters.Add(new CustomNamespaceXmlFormatter { UseXmlSerializer = true });
        }
    }
}
