using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Web.Caching;
using Apps.Common;
using Apps.Models;

namespace Apps.Service
{
    public partial class SysConfigService:IService.ISysConfigService
    {
        private static object lockHelper = new object();
        /// <summary>
        ///  读取配置文件
        /// </summary>
        public SysConfigModel LoadConfig(string configFilePath)
        {
            SysConfigModel model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG);
            if (model == null)
            {
                CacheHelper.Insert(ContextKeys.CACHE_SITE_CONFIG, Load(configFilePath), configFilePath);
                model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG);
            }
            return model;
        }
        /// <summary>
        /// 读取客户端站点配置信息
        /// </summary>
        public SysConfigModel LoadConfig(string configFilePath, bool isClient)
        {
            SysConfigModel model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG_CLIENT);
            if (model == null)
            {
                model = Load(configFilePath);
                model.templateskin = model.webpath + "templates/" + model.templateskin;
                CacheHelper.Insert(ContextKeys.CACHE_SITE_CONFIG_CLIENT, model, configFilePath);
            }
            return model;
        }

       
        public SysConfigModel SaveConifg(SysConfigModel model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
            }
            return model;
        }

        public SysConfigModel Load(string configFilePath)
        {
            return (SysConfigModel)SerializationHelper.Load(typeof(SysConfigModel), configFilePath);
        }
    }
}
