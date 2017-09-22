using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Top.Api.Qimen.Custom
{
    public abstract class CustomRequest<T> where T: CustomResponse
    {
        private Helper.TopDictionary queryParameters;

        public Helper.TopDictionary GetQueryParameters()
        {
            return this.queryParameters;
        }

        public void AddQueryParameter(string key, string value)
        {
            if (this.queryParameters == null)
            {
                this.queryParameters = new Helper.TopDictionary();
            }
            this.queryParameters[key] = value;
        }

        private Helper.TopDictionary headerParameters;

        public Helper.TopDictionary GetHeaderParameters()
        {
            return this.headerParameters;
        }

        public void AddHeaderParameter(string key, string value)
        {
            if (this.headerParameters == null)
            {
                this.headerParameters = new Helper.TopDictionary();
            }
            this.headerParameters[key] = value;
        }

        /// <summary>
        /// 客户ID号
        /// </summary>
        /// 
        [XmlIgnore]
        public string CustomerId { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        /// 
        [XmlIgnore]
        public DateTime Timestamp { get; set; }

        private string _version = "1.0";
        /// <summary>
        /// API版本号
        /// </summary>
        /// 
        [XmlIgnore]
        public string Version { get { return this._version; } set { this._version = value; } }

        /// <summary>
        /// 测试类型
        /// </summary>
        /// 
        [XmlIgnore]
        public string TestType { get; set; }

        /// <summary>
        /// 请求body体
        /// </summary>
        /// 
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 获取API名称
        /// </summary>
        /// <returns></returns>
        public abstract string GetApiName();
    }
}
