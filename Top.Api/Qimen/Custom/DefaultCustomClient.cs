using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Api.Qimen.Custom
{
    public class DefaultCustomClient : ICustomClient
    {
        protected string serverUrl;
        protected string appKey;
        protected string appSecret;
        protected string format = Helper.Constants.FORMAT_XML;
        protected string signMethod = Helper.Constants.SIGN_METHOD_MD5;
        protected int connectTimeout = 15000; // 默认连接超时时间为15秒
        protected int readTimeout = 30000; // 默认响应超时时间为30秒

        private bool disableParser = false; // 禁用响应结果解释
        private bool disableTrace = false; // 禁用日志调试功能
        private bool useGzipEncoding = true;  // 是否启用响应GZIP压缩

        protected Helper.WebUtils webUtils;
        protected ITopLogger topLogger;

        public DefaultQimenClient(string serverUrl, string appKey, string appSecret)
        {
            this.serverUrl = serverUrl;
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.webUtils = new WebUtils();
            this.topLogger = DefaultTopLogger.GetDefault();
        }
        public T Execute<T>(CustomRequest<T> request) where T : CustomResponse
        {
            throw new NotImplementedException();
        }
    }
}
