using Apps.Common;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web.Mvc;

namespace Apps.Service
{
    public class DBSessionFactory
    {
        //[ThreadStatic]
        //private static IRespository.IDBSession _idbSession = null;


        public static IRepository.IDBSession GetDBSession()
        {
            //if (_idbSession == null) _idbSession = Utility.DI.GetObject<IRespository.IDBSession>("dalSession");
            //return _idbSession;

        //1.从线程中取出 键 对应的值
        var dbSession = CallContext.GetData(typeof(DBSessionFactory).FullName) as IRepository.IDBSession;
            //2.如果为空（线程中不存在）
            if (dbSession == null)
            {
                dbSession = DI.GetObject<IRepository.IDBSession>("DBSession");
                //dbSession = DependencyResolver.Current.GetService<IRepository.IDBSession>();
                //3.实例化 EF容器 子类对象
                //db = Utility.DI.GetObject<IRespository.IDBSession>("dalSession");
                //4.并存入线程
                CallContext.SetData(typeof(DBSessionFactory).FullName, dbSession);
            }
            //5.返回DBSession对象
            return dbSession; 
        }
    }
}
