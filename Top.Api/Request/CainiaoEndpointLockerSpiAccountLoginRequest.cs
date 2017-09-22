using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.endpoint.locker.spi.account.login
    /// </summary>
    public class CainiaoEndpointLockerSpiAccountLoginRequest : BaseTopRequest<Top.Api.Response.CainiaoEndpointLockerSpiAccountLoginResponse>
    {
        /// <summary>
        /// 柜子公司编码
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 柜子Id，gui_id和gui_url必须存在一个
        /// </summary>
        public string GuiId { get; set; }

        /// <summary>
        /// 柜子url
        /// </summary>
        public string GuiUrl { get; set; }

        /// <summary>
        /// 开放用户id
        /// </summary>
        public string OpenUserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.endpoint.locker.spi.account.login";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("gui_id", this.GuiId);
            parameters.Add("gui_url", this.GuiUrl);
            parameters.Add("open_user_id", this.OpenUserId);
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
        }

        #endregion
    }
}
