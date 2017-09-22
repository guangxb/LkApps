using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.cntms.logistics.order.consign
    /// </summary>
    public class CainiaoCntmsLogisticsOrderConsignRequest : BaseTopRequest<Top.Api.Response.CainiaoCntmsLogisticsOrderConsignResponse>
    {
        /// <summary>
        /// 配送发货信息
        /// </summary>
        public string Content { get; set; }

        public CnTmsLogisticsOrderConsignContentDomain Content_ { set { this.Content = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.cntms.logistics.order.consign";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// CnTmsLogisticsOrderReceiverInfoDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderReceiverInfoDomain : TopObject
{
	        /// <summary>
	        /// 收件人区县
	        /// </summary>
	        [XmlElement("receiver_address")]
	        public string ReceiverAddress { get; set; }
	
	        /// <summary>
	        /// 收件人区县
	        /// </summary>
	        [XmlElement("receiver_area")]
	        public string ReceiverArea { get; set; }
	
	        /// <summary>
	        /// 收件人城市
	        /// </summary>
	        [XmlElement("receiver_city")]
	        public string ReceiverCity { get; set; }
	
	        /// <summary>
	        /// 收件人手机，手机与电话必须有一值不为空
	        /// </summary>
	        [XmlElement("receiver_mobile")]
	        public string ReceiverMobile { get; set; }
	
	        /// <summary>
	        /// 收件人姓名
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// 收件人昵称
	        /// </summary>
	        [XmlElement("receiver_nick")]
	        public string ReceiverNick { get; set; }
	
	        /// <summary>
	        /// 收件人电话，手机与电话必须有一值不为空
	        /// </summary>
	        [XmlElement("receiver_phone")]
	        public string ReceiverPhone { get; set; }
	
	        /// <summary>
	        /// 收件人省份
	        /// </summary>
	        [XmlElement("receiver_province")]
	        public string ReceiverProvince { get; set; }
	
	        /// <summary>
	        /// 收件方邮编
	        /// </summary>
	        [XmlElement("receiver_zip_code")]
	        public string ReceiverZipCode { get; set; }
}

	/// <summary>
/// CnTmsLogisticsOrderSenderinfoDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderSenderinfoDomain : TopObject
{
	        /// <summary>
	        /// 发件人地址
	        /// </summary>
	        [XmlElement("sender_address")]
	        public string SenderAddress { get; set; }
	
	        /// <summary>
	        /// 发件人区县
	        /// </summary>
	        [XmlElement("sender_area")]
	        public string SenderArea { get; set; }
	
	        /// <summary>
	        /// 发件人城市
	        /// </summary>
	        [XmlElement("sender_city")]
	        public string SenderCity { get; set; }
	
	        /// <summary>
	        /// 发件人手机，手机与电话必须有一值不为空
	        /// </summary>
	        [XmlElement("sender_mobile")]
	        public string SenderMobile { get; set; }
	
	        /// <summary>
	        /// 发件人姓名
	        /// </summary>
	        [XmlElement("sender_name")]
	        public string SenderName { get; set; }
	
	        /// <summary>
	        /// 发件人电话，手机与电话必须有一值不为空
	        /// </summary>
	        [XmlElement("sender_phone")]
	        public string SenderPhone { get; set; }
	
	        /// <summary>
	        /// 发件人省份
	        /// </summary>
	        [XmlElement("sender_province")]
	        public string SenderProvince { get; set; }
	
	        /// <summary>
	        /// 发件人邮编
	        /// </summary>
	        [XmlElement("sender_zip_code")]
	        public string SenderZipCode { get; set; }
}

	/// <summary>
/// CnTmsLogisticsOrderItemDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderItemDomain : TopObject
{
	        /// <summary>
	        /// 扩展字段 K:V;
	        /// </summary>
	        [XmlElement("extend_fields")]
	        public string ExtendFields { get; set; }
	
	        /// <summary>
	        /// 发货商品名称
	        /// </summary>
	        [XmlElement("item_name")]
	        public string ItemName { get; set; }
	
	        /// <summary>
	        /// 商品单价，单位分
	        /// </summary>
	        [XmlElement("item_price")]
	        public Nullable<long> ItemPrice { get; set; }
	
	        /// <summary>
	        /// ERP订单明细编码
	        /// </summary>
	        [XmlElement("order_item_id")]
	        public string OrderItemId { get; set; }
	
	        /// <summary>
	        /// 发货商品商品数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 子交易号
	        /// </summary>
	        [XmlElement("sub_trade_id")]
	        public string SubTradeId { get; set; }
}

	/// <summary>
/// CnTmsLogisticsOrderDeliverRequirementsDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderDeliverRequirementsDomain : TopObject
{
	        /// <summary>
	        /// 配送类型： PTPS-普通配送 LLPS-冷链配送
	        /// </summary>
	        [XmlElement("delivery_type")]
	        public string DeliveryType { get; set; }
	
	        /// <summary>
	        /// 送达日期（格式为 yyyy-MM-dd)
	        /// </summary>
	        [XmlElement("schedule_day")]
	        public string ScheduleDay { get; set; }
	
	        /// <summary>
	        /// 送达结束时间（格式为 hh:mm）
	        /// </summary>
	        [XmlElement("schedule_end")]
	        public string ScheduleEnd { get; set; }
	
	        /// <summary>
	        /// 送达开始时间（格式为 hh:mm）
	        /// </summary>
	        [XmlElement("schedule_start")]
	        public string ScheduleStart { get; set; }
	
	        /// <summary>
	        /// 投递时延要求(1 工作日 2 节假日 104 预约达 )
	        /// </summary>
	        [XmlElement("schedule_type")]
	        public string ScheduleType { get; set; }
}

	/// <summary>
/// CnTmsLogisticsOrderGotServiceDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderGotServiceDomain : TopObject
{
	        /// <summary>
	        /// 揽收日期yyyyMMdd
	        /// </summary>
	        [XmlElement("got_date")]
	        public string GotDate { get; set; }
	
	        /// <summary>
	        /// 揽收时间段 09:00-10:00
	        /// </summary>
	        [XmlElement("got_range")]
	        public string GotRange { get; set; }
}

	/// <summary>
/// CnTmsLogisticsOrderConsignContentDomain Data Structure.
/// </summary>
[Serializable]

public class CnTmsLogisticsOrderConsignContentDomain : TopObject
{
	        /// <summary>
	        /// 配送要求信息（当前业务暂不支持）
	        /// </summary>
	        [XmlElement("deliver_requirements")]
	        public CnTmsLogisticsOrderDeliverRequirementsDomain DeliverRequirements { get; set; }
	
	        /// <summary>
	        /// 扩展字段 K:V;
	        /// </summary>
	        [XmlElement("extend_fields")]
	        public string ExtendFields { get; set; }
	
	        /// <summary>
	        /// 发货商品信息，最大50条记录
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("cn_tms_logistics_order_item")]
	        public List<CnTmsLogisticsOrderItemDomain> Items { get; set; }
	
	        /// <summary>
	        /// 运单号
	        /// </summary>
	        [XmlElement("mail_no")]
	        public string MailNo { get; set; }
	
	        /// <summary>
	        /// ERP订单号
	        /// </summary>
	        [XmlElement("order_code")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 来源渠道（TB 淘宝，JD 京东，TM 天猫，1688 1688（阿里中文站），YHD 1号店，DD 当当，VANCL 凡客，PP 拍拍，YX 易讯，EBAY 易贝ebay，AMAZON 亚马逊，SN 苏宁在线，GM 国美在线，WPH 唯品会，JM 聚美优品，LF 乐蜂网，MGJ 蘑菇街，JS 聚尚网，YG 优购，YT 银泰，YL 邮乐，PX 拍鞋网，POS POS门店，OTHERS 其他）
	        /// </summary>
	        [XmlElement("order_source")]
	        public string OrderSource { get; set; }
	
	        /// <summary>
	        /// 此订单总的包裹数，如订单拆包裹时，传入此参数，配送时会将同一订单的包裹一配送
	        /// </summary>
	        [XmlElement("package_count")]
	        public Nullable<long> PackageCount { get; set; }
	
	        /// <summary>
	        /// 包裹高度（厘米）
	        /// </summary>
	        [XmlElement("package_height")]
	        public Nullable<long> PackageHeight { get; set; }
	
	        /// <summary>
	        /// 包裹长度（厘米）
	        /// </summary>
	        [XmlElement("package_length")]
	        public Nullable<long> PackageLength { get; set; }
	
	        /// <summary>
	        /// 此订单的第几个包裹，如订单拆包裹时，传入此参数，配送时会将同一订单的包裹一配送
	        /// </summary>
	        [XmlElement("package_no")]
	        public Nullable<long> PackageNo { get; set; }
	
	        /// <summary>
	        /// 包裹体积（立方厘米）
	        /// </summary>
	        [XmlElement("package_volume")]
	        public Nullable<long> PackageVolume { get; set; }
	
	        /// <summary>
	        /// 包裹重量（克）
	        /// </summary>
	        [XmlElement("package_weight")]
	        public Nullable<long> PackageWeight { get; set; }
	
	        /// <summary>
	        /// 包裹宽度（厘米）
	        /// </summary>
	        [XmlElement("package_width")]
	        public Nullable<long> PackageWidth { get; set; }
	
	        /// <summary>
	        /// 商家送货方式，1商家送货，2菜鸟揽货
	        /// </summary>
	        [XmlElement("pick_up_type")]
	        public Nullable<long> PickUpType { get; set; }
	
	        /// <summary>
	        /// 配送发货单收件人信息
	        /// </summary>
	        [XmlElement("receiver_info")]
	        public CnTmsLogisticsOrderReceiverInfoDomain ReceiverInfo { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 配送发货单发件人信息
	        /// </summary>
	        [XmlElement("sender_info")]
	        public CnTmsLogisticsOrderSenderinfoDomain SenderInfo { get; set; }
	
	        /// <summary>
	        /// 店铺编码
	        /// </summary>
	        [XmlElement("shop_code")]
	        public string ShopCode { get; set; }
	
	        /// <summary>
	        /// 物流服务解决方案Code，此字段由菜鸟提供
	        /// </summary>
	        [XmlElement("solutions_code")]
	        public string SolutionsCode { get; set; }
	
	        /// <summary>
	        /// 物流公司编码
	        /// </summary>
	        [XmlElement("tms_code")]
	        public string TmsCode { get; set; }
	
	        /// <summary>
	        /// 要求菜鸟上门揽货服务，当pick_up_Type=2且需求指定时做揽收时，此字段需要传值（当前业务暂不支持）
	        /// </summary>
	        [XmlElement("tms_got_service")]
	        public CnTmsLogisticsOrderGotServiceDomain TmsGotService { get; set; }
	
	        /// <summary>
	        /// 交易订单id或者商家订单号； 若阿里系订单，必须与阿里对应
	        /// </summary>
	        [XmlElement("trade_id")]
	        public string TradeId { get; set; }
}

        #endregion
    }
}
