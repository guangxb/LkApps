using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.yima.locker.account.authorize.status.query
    /// </summary>
    public class CainiaoYimaLockerAccountAuthorizeStatusQueryRequest : BaseTopRequest<Top.Api.Response.CainiaoYimaLockerAccountAuthorizeStatusQueryResponse>
    {
        /// <summary>
        /// 柜子url
        /// </summary>
        public string GuiUrl { get; set; }

        /// <summary>
        /// 小件员id
        /// </summary>
        public Nullable<long> UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.yima.locker.account.authorize.status.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("gui_url", this.GuiUrl);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("gui_url", this.GuiUrl);
            RequestValidator.ValidateRequired("user_id", this.UserId);
        }

        #endregion
    }
}
