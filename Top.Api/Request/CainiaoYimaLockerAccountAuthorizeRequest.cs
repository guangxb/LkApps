using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.yima.locker.account.authorize
    /// </summary>
    public class CainiaoYimaLockerAccountAuthorizeRequest : BaseTopRequest<Top.Api.Response.CainiaoYimaLockerAccountAuthorizeResponse>
    {
        /// <summary>
        /// 一次性授权码
        /// </summary>
        public string AccessCode { get; set; }

        /// <summary>
        /// 授权自提柜的linkappkey
        /// </summary>
        public string LinkAppkey { get; set; }

        /// <summary>
        /// 小件员id
        /// </summary>
        public Nullable<long> UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.yima.locker.account.authorize";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_code", this.AccessCode);
            parameters.Add("link_appkey", this.LinkAppkey);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("access_code", this.AccessCode);
            RequestValidator.ValidateRequired("link_appkey", this.LinkAppkey);
            RequestValidator.ValidateRequired("user_id", this.UserId);
        }

        #endregion
    }
}
