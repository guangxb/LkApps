using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.endpoint.locker.spi.account.authorize
    /// </summary>
    public class CainiaoEndpointLockerSpiAccountAuthorizeRequest : BaseTopRequest<Top.Api.Response.CainiaoEndpointLockerSpiAccountAuthorizeResponse>
    {
        /// <summary>
        /// 一次性授权码
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// 柜子公司编码
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 开放用户id
        /// </summary>
        public string OpenUserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.endpoint.locker.spi.account.authorize";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_code", this.AuthCode);
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("open_user_id", this.OpenUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("auth_code", this.AuthCode);
            RequestValidator.ValidateRequired("company_code", this.CompanyCode);
            RequestValidator.ValidateRequired("open_user_id", this.OpenUserId);
        }

        #endregion
    }
}
