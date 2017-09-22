using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.StockOutCreateModel
{
    public class StockOutCreateModel
    {

    }

    [XmlRoot("request", IsNullable = false)]
    public class StockOutCreateRequestModel
    {
        [XmlElement(ElementName = "deliveryOrder")]
        public DeliveryOrder DeliveryOrder { get; set; }
        [XmlArray(ElementName = "orderLines"), XmlArrayItem(ElementName = "orderLine")]
        public List<OrderLine> OrderLines { get; set; }
    }
    [XmlRoot("response", IsNullable = false)]
    public class StockOutCreateResponseModel
    {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        [XmlElement(ElementName = "createTime")]
        public string CreateTime { get; set; }
        [XmlElement(ElementName = "deliveryOrderId")]
        public string DeliveryOrderId { get; set; }
    }

    public class DeliveryOrder {
        [XmlElement(ElementName = "deliveryOrderCode")]
        public string DeliveryOrderCode { get; set; }
        [XmlElement(ElementName = "orderType")]
        public string OrderType { get; set; }
        [XmlElement(ElementName = "warehouseCode")]
        public string WarehouseCode { get; set; }
        [XmlElement(ElementName = "createTime")]
        public string CreateTime { get; set; }
        [XmlElement(ElementName = "senderInfo")]
        public SenderInfo SenderInfo { get; set; }
        [XmlElement(ElementName = "receiverInfo")]
        public ReceiverInfo ReceiverInfo { get; set; }
        [XmlElement(ElementName = "logisticsCode")]
        public string LogisticsCode { get; set; }
    }
    //发件人信息
    public class SenderInfo {
        //发件人姓名
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "mobile")]
        public string Mobile { get; set; }
        [XmlElement(ElementName = "province")]
        public string Province { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
        [XmlElement(ElementName = "detailAddress")]
        public string DetailAddress { get; set; }
    }

    public class ReceiverInfo {


        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "mobile")]
        public string Mobile { get; set; }
        [XmlElement(ElementName = "province")]
        public string Province { get; set; }
        [XmlElement(ElementName = "city")]
        public string City { get; set; }
        [XmlElement(ElementName = "detailAddress")]
        public string DetailAddress { get; set; }

        [XmlElement(ElementName = "area")]
        public string Area { get; set; }
        [XmlElement(ElementName = "town")]
        public string Town { get; set; }
        [XmlElement(ElementName = "remark")]
        public string Remark { get; set; }
    }

    public class OrderLine {
        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }
        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "planQty")]
        public int PlanQty { get; set; }
        [XmlElement(ElementName = "itemName")]
        public string ItemName { get; set; }
        [XmlElement(ElementName = "inventoryType")]
        public string InventoryType { get; set; }
    }

}