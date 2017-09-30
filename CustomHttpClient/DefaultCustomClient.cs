using System;
using System.Collections.Generic;
using System.Text;
using CustomHttpClient.Helper;
using Newtonsoft.Json;

namespace CustomHttpClient
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
        protected Helper.ICustomLogger logger;

        public DefaultCustomClient(string serverUrl, string appKey, string appSecret)
        {
            this.serverUrl = serverUrl;
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.webUtils = new Helper.WebUtils();
            this.logger = DefaultCustomLogger.GetDefault();
        }
        public T Execute<T>(CustomRequest<T> request) where T : CustomResponse
        {
            return Execute(request, null);
        }

        public T Execute<T>(CustomRequest<T> request, string session) where T : CustomResponse
        {
            return DoExecute(request, session);
        }

        private T DoExecute<T>(CustomRequest<T> request, string session) where T : CustomResponse
        {
            long start = DateTime.Now.Ticks;

            // 添加协议级请求参数
            CustomDictionary parameters = new CustomDictionary();
            if (request.GetQueryParameters() != null)
            {
                parameters.AddAll(request.GetQueryParameters());
            }

            if (string.IsNullOrEmpty(appKey) && string.IsNullOrEmpty(appSecret)) {
                parameters.Add("accept", "application/json");
            }
            else
            {
                parameters.Add(Constants.METHOD, request.GetApiName());
                parameters.Add(Constants.VERSION, request.Version);
                parameters.Add(Constants.APP_KEY, appKey);
                parameters.Add(Constants.TIMESTAMP, request.Timestamp);
                parameters.Add(Constants.FORMAT, format);
                parameters.Add(Constants.SIGN_METHOD, signMethod);
                parameters.Add(Constants.SESSION, session);
                parameters.Add(Constants.PARTNER_ID, Constants.SDK_VERSION);
                parameters.Add(Constants.QM_CUSTOMER_ID, request.CustomerId);
            }

            //json
            //parameters.Add();

            // 添加头部参数
            if (this.useGzipEncoding)
            {
                request.AddHeaderParameter(Constants.ACCEPT_ENCODING, Constants.CONTENT_ENCODING_GZIP);
            }

            try
            {
                string reqBody = request.Body;
                if (string.IsNullOrEmpty(reqBody))
                {
                    //XmlWriter writer = new XmlWriter(Constants.QM_ROOT_TAG_REQ, typeof(QimenRequest<T>));
                    //reqBody = writer.Write(request);
                    if (string.IsNullOrEmpty(appKey) && string.IsNullOrEmpty(appSecret))
                    {
                        reqBody = JsonConvert.SerializeObject(request);
                    }
                    else
                    {
                        reqBody = XmlSerializeHelper.XmlSerialize(request);
                    }

                }

                // 添加签名参数

                string fullUrl = WebUtils.BuildRequestUrl(serverUrl, parameters);
                string rspBody = webUtils.DoPost(fullUrl, Encoding.UTF8.GetBytes(reqBody), Constants.QM_CONTENT_TYPE, request.GetHeaderParameters());

                // 解释响应结果
                T rsp = null;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                    rsp.Body = rspBody;
                }
                else
                {
                    if (string.IsNullOrEmpty(appKey) && string.IsNullOrEmpty(appSecret))
                    {
                        rsp = JsonConvert.DeserializeObject<T>(rspBody);
                    }
                    else
                    {
                        if (Constants.FORMAT_XML.Equals(format, StringComparison.OrdinalIgnoreCase))
                        {
                            XmlDeserializeHelper<T> helper = new XmlDeserializeHelper<T>();
                            rsp = helper.Parse(rspBody);
                        }
                    }
                  
                }

                // 追踪错误的请求
                if (rsp != null && rsp.IsError)
                {
                    TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                    TraceApiError(appKey, request.GetApiName(), serverUrl, parameters, latency.TotalMilliseconds, rspBody);
                }
                return rsp;
            }
            catch (Exception e)
            {
                TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                TraceApiError(appKey, request.GetApiName(), serverUrl, parameters, latency.TotalMilliseconds, e.GetType() + ": " + e.Message);
                throw e;
            }
        }

        public void SetTimeout(int timeout)
        {
            this.webUtils.Timeout = timeout;
        }

        public void SetReadWriteTimeout(int readWriteTimeout)
        {
            this.webUtils.ReadWriteTimeout = readWriteTimeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetUseGzipEncoding(bool useGzipEncoding)
        {
            this.useGzipEncoding = useGzipEncoding;
        }

        public void SetIgnoreSSLCheck(bool ignore)
        {
            this.webUtils.IgnoreSSLCheck = ignore;
        }

        private void TraceApiError(string appKey, string apiName, string url, Dictionary<string, string> parameters, double latency, string errorMessage)
        {
            if (!disableTrace)
            {
                this.logger.TraceApiError(appKey, apiName, url, parameters, latency, errorMessage);
            }
        }
    }
}
