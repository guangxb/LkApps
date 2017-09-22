using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.endpoint.locker.top.withhold.query
    /// </summary>
    public class CainiaoEndpointLockerTopWithholdQueryRequest : BaseTopRequest<Top.Api.Response.CainiaoEndpointLockerTopWithholdQueryResponse>
    {
        /// <summary>
        /// 柜子公司编码
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 开放用户Id
        /// </summary>
        public string OpenUserId { get; set; }

        /// <summary>
        /// 柜子业务：0-取件业务，1-寄件业务，2-派样业务，3-小件员约柜（在约期内仅能使用一次）4-小件员租柜（在约期内可反复使用）
        /// </summary>
        public Nullable<long> OrderType { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.endpoint.locker.top.withhold.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("open_user_id", this.OpenUserId);
            parameters.Add("order_type", this.OrderType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("company_code", this.CompanyCode);
            RequestValidator.ValidateRequired("open_user_id", this.OpenUserId);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
        }

        #endregion
    }
}
