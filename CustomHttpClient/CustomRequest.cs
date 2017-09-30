using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CustomHttpClient
{
    public abstract class CustomRequest<T> where T: CustomResponse
    {
        private Helper.CustomDictionary queryParameters;

        public Helper.CustomDictionary GetQueryParameters()
        {
            return this.queryParameters;
        }

        public void AddQueryParameter(string key, string value)
        {
            if (this.queryParameters == null)
            {
                this.queryParameters = new Helper.CustomDictionary();
            }
            this.queryParameters[key] = value;
        }

        private Helper.CustomDictionary headerParameters;

        public Helper.CustomDictionary GetHeaderParameters()
        {
            return this.headerParameters;
        }

        public void AddHeaderParameter(string key, string value)
        {
            if (this.headerParameters == null)
            {
                this.headerParameters = new Helper.CustomDictionary();
            }
            this.headerParameters[key] = value;
        }

        /// <summary>
        /// 客户ID号
        /// </summary>
        /// 
        [XmlIgnore, JsonIgnore]
        public string CustomerId { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        /// 
        [XmlIgnore, JsonIgnore]
        public DateTime Timestamp { get; set; }

        private string _version = "1.0";
        /// <summary>
        /// API版本号
        /// </summary>
        /// 
        [XmlIgnore, JsonIgnore]
        public string Version { get { return this._version; } set { this._version = value; } }

        /// <summary>
        /// 测试类型
        /// </summary>
        /// 
        [XmlIgnore, JsonIgnore]
        public string TestType { get; set; }

        /// <summary>
        /// 请求body体
        /// </summary>
        /// 
        [XmlIgnore, JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 获取API名称
        /// </summary>
        /// <returns></returns>
        public abstract string GetApiName();
    }
}
