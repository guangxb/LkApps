using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.EntryorderCreateModel
{
    [XmlRoot("response", Namespace = "", IsNullable = false)]
    public class EntryorderCreateResponseModel
    {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        [XmlElement(ElementName = "entryOrderId")]
        public string EntryOrderId { get; set; }

    }


    [XmlRoot("request", IsNullable = false)]
    public class EntryorderCreateRequestModel
    {
        [XmlElement(ElementName = "entryOrder")]
        public EntryOrder EntryOrder { get; set; }
        [XmlArray(ElementName = "orderLines"), XmlArrayItem(ElementName = "orderLine")]
        public List<OrderLine> OrderLines { get; set; }
    }

    public class EntryOrder
    {
        [XmlElement(ElementName = "entryOrderCode")]
        public string EntryOrderCode { get; set; }
        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }
        [XmlElement(ElementName = "warehouseCode")]
        public string WarehouseCode { get; set; }
        [XmlElement(ElementName = "orderType")]
        public string OrderType { get; set; }
        [XmlElement(ElementName = "orderCreateTime")]
        public string OrderCreateTime { get; set; }
        [XmlElement(ElementName = "totalOrderLines")]
        public string TotalOrderLines { get; set; }

    }

    public class OrderLine
    {
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