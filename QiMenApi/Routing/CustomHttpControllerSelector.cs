using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace QiMenApi.Routing
{
    public class CustomHttpControllerSelector : DefaultHttpControllerSelector
    {
        public CustomHttpControllerSelector(HttpConfiguration configuration)
            : base(configuration)
        {
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            request.RequestUri = new Uri("");
            return base.SelectController(request);
        }
    }
}