using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.inventoryreserve.create
    /// </summary>
    public class InventoryreserveCreateRequest : QimenRequest<Qimen.Api.Response.InventoryreserveCreateResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<ItemInventoryDomain> ItemInventories { get; set; }

        /// <summary>
        /// 最大仓库数(当一个仓库不满足库存时.是否允许占用多个仓库库存.如果允许.需要指定最大分仓数量.但不能拆分订单明细. 0：不限个数.只要满足发货.不限分占几个仓库 1：默认值.只能单仓发 >1:最大 占用数量)
        /// </summary>
        public Nullable<long> MaxWarehouseNum { get; set; }

        /// <summary>
        /// ERP订单编码
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单来源(213 天猫、201 淘宝、214 京东、202 1688 阿里中文站、203 苏宁在线、204 亚马逊中国、205 当当、208 1号店、207 唯品会、209 国美在线、210 拍拍、206 易贝ebay、211 聚美优品、212 乐蜂 网、215 邮乐、216 凡客、217 优购、218 银泰、219 易讯、221 聚尚网、222 蘑菇街、223 POS门店、301 其他)
        /// </summary>
        public Nullable<long> OrderSource { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        public string OwnerCode { get; set; }

        public ReceiverInfoDomain ReceiverInfo { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.inventoryreserve.create";
        }


	/// <summary>
/// ReceiverInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ReceiverInfoDomain
{
	        /// <summary>
	        /// 区域
	        /// </summary>
	        [XmlElement("area")]
	        public string Area { get; set; }
	
	        /// <summary>
	        /// 城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 村镇
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// 邮编
	        /// </summary>
	        [XmlElement("zipCode")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// ItemInventoryDomain Data Structure.
/// </summary>
[Serializable]

public class ItemInventoryDomain
{
	        /// <summary>
	        /// 菜鸟商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 菜鸟商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 订单交易编码
	        /// </summary>
	        [XmlElement("orderSourceCode")]
	        public string OrderSourceCode { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 子交易编码
	        /// </summary>
	        [XmlElement("subSourceCode")]
	        public string SubSourceCode { get; set; }
}

        #endregion
    }
}
