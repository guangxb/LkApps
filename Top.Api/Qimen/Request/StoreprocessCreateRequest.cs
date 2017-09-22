using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.storeprocess.create
    /// </summary>
    public class StoreprocessCreateRequest : QimenRequest<Qimen.Api.Response.StoreprocessCreateResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string ExtendProps { get; set; }

        public List<MaterialItemDomain> Materialitems { get; set; }

        /// <summary>
        /// 加工单创建时间(YYYY-MM-DD HH:MM:SS)
        /// </summary>
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 单据类型(CNJG=仓内加工作业单)
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 成品计划数量
        /// </summary>
        public Nullable<long> PlanQty { get; set; }

        /// <summary>
        /// 计划加工时间(YYYY-MM-DD HH:MM:SS)
        /// </summary>
        public string PlanTime { get; set; }

        /// <summary>
        /// 加工单编码
        /// </summary>
        public string ProcessOrderCode { get; set; }

        public List<ProductItemDomain> Productitems { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 加工类型(1:仓内组合加工 2:仓内组合拆分)
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
        /// </summary>
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.storeprocess.create";
        }


	/// <summary>
/// MaterialItemDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("item")]
public class MaterialItemDomain
{
	        /// <summary>
	        /// 奇门仓储字段,说明,string(50),,
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;默认为ZP)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// erp系统商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 商品生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 配比数量
	        /// </summary>
	        [XmlElement("ratioQty")]
	        public Nullable<long> RatioQty { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

	/// <summary>
/// ProductItemDomain Data Structure.
/// </summary>
[Serializable]
[Top.Api.Util.ApiListType("item")]
public class ProductItemDomain
{
	        /// <summary>
	        /// batchCode
	        /// </summary>
	        [XmlElement("batchCode")]
	        public string BatchCode { get; set; }
	
	        /// <summary>
	        /// 商品过期日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("expireDate")]
	        public string ExpireDate { get; set; }
	
	        /// <summary>
	        /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;默认为ZP)
	        /// </summary>
	        [XmlElement("inventoryType")]
	        public string InventoryType { get; set; }
	
	        /// <summary>
	        /// erp系统商品编码
	        /// </summary>
	        [XmlElement("itemCode")]
	        public string ItemCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统商品ID
	        /// </summary>
	        [XmlElement("itemId")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// 货主编码
	        /// </summary>
	        [XmlElement("ownerCode")]
	        public string OwnerCode { get; set; }
	
	        /// <summary>
	        /// 生产批号
	        /// </summary>
	        [XmlElement("produceCode")]
	        public string ProduceCode { get; set; }
	
	        /// <summary>
	        /// 商品生产日期(YYYY-MM-DD)
	        /// </summary>
	        [XmlElement("productDate")]
	        public string ProductDate { get; set; }
	
	        /// <summary>
	        /// 数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// 配比数量
	        /// </summary>
	        [XmlElement("ratioQty")]
	        public Nullable<long> RatioQty { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

        #endregion
    }
}
