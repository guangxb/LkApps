using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.OrderCancelModel
{
    public class OrderCancelModel
    {
    }
    [XmlRoot("request", Namespace = "", IsNullable = false)]
    public class OrderCancelRequestModel
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        /// 
        [XmlElement(ElementName = "cancelReason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        /// 
        [XmlElement(ElementName = "extendProps")]
        public string ExtendProps { get; set; }

        /// <summary>
        /// 单据编码
        /// </summary>
        /// 
        [XmlElement(ElementName = "orderCode")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 仓储系统单据编码
        /// </summary>
        /// 
        [XmlElement(ElementName = "orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// 单据类型(JYCK=一般交易出库单;HHCK= 换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;B2BRK=B2B入库;B2BCK=B2B出库;QTCK=其他出库;SCRK=生产入库;LYRK=领用入库;CCRK=残次品入库;CGRK=采购入库;DBRK= 调拨入库;QTRK=其他入库;XTRK= 销退入库;THRK=退货入库;HHRK= 换货入库;CNJG= 仓内加工单;CGTH=采购退货出库单)
        /// </summary>
        /// 
        [XmlElement(ElementName = "orderType")]
        public string OrderType { get; set; }

        /// <summary>
        /// 货主编码
        /// </summary>
        /// 
        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// 
        [XmlElement(ElementName = "remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
        /// </summary>
        /// 
        [XmlElement(ElementName = "warehouseCode")]
        public string WarehouseCode { get; set; }

        #region ITopRequest Members

        #endregion
    }
    [XmlRoot("response", Namespace = "", IsNullable = false)]
    public class OrderCancelResponseModel {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
    }
}