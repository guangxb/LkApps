using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// OrderprocessQueryResponse.
    /// </summary>
    public class OrderprocessQueryResponse : QimenResponse
    {
        /// <summary>
        /// 订单处理流程
        /// </summary>
        [XmlElement("orderProcess")]
        public OrderProcessDomain OrderProcess { get; set; }

	/// <summary>
/// ProcessDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessDomain : TopObject
{
	        /// <summary>
	        /// 操作内容
	        /// </summary>
	        [XmlElement("operateInfo")]
	        public string OperateInfo { get; set; }
	
	        /// <summary>
	        /// 该状态操作时间(YYYY-MM-DD HH:MM:SS)
	        /// </summary>
	        [XmlElement("operateTime")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// 该状态操作员编码
	        /// </summary>
	        [XmlElement("operatorCode")]
	        public string OperatorCode { get; set; }
	
	        /// <summary>
	        /// 该状态操作员姓名
	        /// </summary>
	        [XmlElement("operatorName")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 单据状态(NEW=新增;ACCEPT=仓库接单;PRINT=打印;PICK=捡货;CHECK=复核;PACKAGE=打包;WEIGH=称重;READY=待提货;DELIVERED=已发货;EXCEPTION=异常;CLOSED=关闭;CANCELED=取消;REJECT=仓库拒单;REFUSE=客户拒签;CANCELEDFAIL=取消失败;SIGN=签收;TMSCANCELED=快递拦截;PARTFULFILLED=部分收货完成;FULFILLED=收货完成;PARTDELIVERED=部分发货完成;OTHER=其他;只传英文编码)
	        /// </summary>
	        [XmlElement("processStatus")]
	        public string ProcessStatus { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

	/// <summary>
/// OrderProcessDomain Data Structure.
/// </summary>
[Serializable]

public class OrderProcessDomain : TopObject
{
	        /// <summary>
	        /// 单据号
	        /// </summary>
	        [XmlElement("orderCode")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 仓储系统单据号
	        /// </summary>
	        [XmlElement("orderId")]
	        public string OrderId { get; set; }
	
	        /// <summary>
	        /// 单据类型(JYCK=一般交易出库单;HHCK=换货出库;BFCK=补发出库;PTCK=普通出库单;DBCK=调拨出库;QTCK=其他出库;B2BRK=B2B入库;B2BCK=B2B出库;CGRK=采购入库;DBRK=调拨入库;QTRK=其他入库;XTRK=销退入库;HHRK=换货入库;CNJG=仓内加工单)
	        /// </summary>
	        [XmlElement("orderType")]
	        public string OrderType { get; set; }
	
	        /// <summary>
	        /// 处理流程
	        /// </summary>
	        [XmlArray("processes")]
	        [XmlArrayItem("process")]
	        public List<ProcessDomain> Processes { get; set; }
	
	        /// <summary>
	        /// 仓库编码
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
}

    }
}
