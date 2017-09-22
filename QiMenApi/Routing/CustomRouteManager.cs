using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QiMenApi.Routing
{
    public class CustomRouteModel
    {
        public string MethodName { get; set; }
        public string ControllerName { get; set; }
    }

    public static class CustomRouteManager
    {
        public static readonly List<CustomRouteModel> AllRouteMap = new List<CustomRouteModel>
        {
            new CustomRouteModel() {MethodName="taobao.qimen.items.synchronize",ControllerName="ItemsSynchronize" },
        };
    }
}