using Spring.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Common
{
    public class DI
    {
        //[ThreadStatic]
        //private static IApplicationContext objFactory = null;

        private static IApplicationContext GetFactory()
        {
            var objFactory = CallContext.GetData(typeof(DI).FullName) as IApplicationContext;
            if (objFactory == null)
            {
                objFactory = Spring.Context.Support.ContextRegistry.GetContext();
            }
            return objFactory;

            //return Spring.Context.Support.ContextRegistry.GetContext();
        }

        public static T GetObject<T>(string objectName) where T : class
        {
            return (T)GetFactory().GetObject(objectName);
        }
    }
}
