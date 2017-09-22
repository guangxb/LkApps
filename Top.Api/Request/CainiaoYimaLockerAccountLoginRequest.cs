using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.yima.locker.account.login
    /// </summary>
    public class CainiaoYimaLockerAccountLoginRequest : BaseTopRequest<Top.Api.Response.CainiaoYimaLockerAccountLoginResponse>
    {
        /// <summary>
        /// 柜子url
        /// </summary>
        public string GuiUrl { get; set; }

        /// <summary>
        /// 当前纬度
        /// </summary>
        public string Lat { get; set; }

        /// <summary>
        /// 当前经度
        /// </summary>
        public string Lng { get; set; }

        /// <summary>
        /// 小件员id
        /// </summary>
        public string UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.yima.locker.account.login";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("gui_url", this.GuiUrl);
            parameters.Add("lat", this.Lat);
            parameters.Add("lng", this.Lng);
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
