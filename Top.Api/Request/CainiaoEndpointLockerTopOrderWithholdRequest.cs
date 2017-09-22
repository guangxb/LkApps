using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.endpoint.locker.top.order.withhold
    /// </summary>
    public class CainiaoEndpointLockerTopOrderWithholdRequest : BaseTopRequest<Top.Api.Response.CainiaoEndpointLockerTopOrderWithholdResponse>
    {
        /// <summary>
        /// 柜子公司编码
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// 柜子id
        /// </summary>
        public string GuiId { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        public string MailNo { get; set; }

        /// <summary>
        /// 开放用户id
        /// </summary>
        public string OpenUserId { get; set; }

        /// <summary>
        /// 柜子订单编码
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单类型(0-取件业务，1-寄件业务，2-派样业务)
        /// </summary>
        public Nullable<long> OrderType { get; set; }

        /// <summary>
        /// 代扣金额（全额），单位：分
        /// </summary>
        public Nullable<long> TotalFee { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.endpoint.locker.top.order.withhold";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("extra", this.Extra);
            parameters.Add("gui_id", this.GuiId);
            parameters.Add("mail_no", this.MailNo);
            parameters.Add("open_user_id", this.OpenUserId);
            parameters.Add("order_code", this.OrderCode);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("total_fee", this.TotalFee);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("company_code", this.CompanyCode);
            RequestValidator.ValidateRequired("gui_id", this.GuiId);
            RequestValidator.ValidateRequired("mail_no", this.MailNo);
            RequestValidator.ValidateRequired("open_user_id", this.OpenUserId);
            RequestValidator.ValidateRequired("order_code", this.OrderCode);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateRequired("total_fee", this.TotalFee);
        }

        #endregion
    }
}
