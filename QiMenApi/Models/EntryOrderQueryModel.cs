using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.EntryOrderQueryModel
{
    [XmlRoot("request", IsNullable = false)]
    public class EntryOrderQueryRequestModel {
        [XmlElement("ownerCode")]
        public string OwnerCode { get; set; }
        [XmlElement("warehouseCode")]
        public string WarehouseCode { get; set; }
        [XmlElement("entryOrderCode")]
        public string EntryOrderCode { get; set; }
        [XmlElement("entryOrderId")]
        public string EntryOrderId { get; set; }
        [XmlElement("pageSize")]
        public string PageSize { get; set; }
        [XmlElement("page")]
        public string Page { get; set; }
    }
    [XmlRoot("response", IsNullable = false)]
    public class EntryOrderQueryResponseModel
    {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }

        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }

        [XmlElement(ElementName = "totalLines")]
        public int TotalLines { get; set; }

        [XmlElement(ElementName = "entryOrder")]
        public EntryOrder EntryOrder { get; set; }
        [XmlArray(ElementName ="orderLines"),XmlArrayItem(ElementName ="orderLine")]
        //[XmlElement(ElementName = "orderLines")]
        public List<OrderLine> OrderLines { get; set; }
    }

    [Serializable]
    public class OrderLine
    {
        [XmlElement(ElementName = "orderLineNo")]
        public string OrderLineNo { get; set; }

        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }

        [XmlElement(ElementName = "itemId")]
        public string ItemId { get; set; }

        [XmlElement(ElementName = "itemName")]
        public string ItemName { get; set; }

        [XmlElement(ElementName = "planQty")]
        public int PlanQty { get; set; }

        [XmlElement(ElementName = "actualQty")]
        public int ActualQty { get; set; }

        [XmlElement(ElementName = "inventoryType")]
        public string InventoryType { get; set; }

        [XmlElement(ElementName = "productDate")]
        public string ProductDate { get; set; }

        [XmlElement(ElementName = "expireDate")]
        public string ExpireDate { get; set; }

        [XmlElement(ElementName = "produceCode")]
        public string ProduceCode { get; set; }

        [XmlElement(ElementName = "batchCode")]
        public string BatchCode { get; set; }

        [XmlElement(ElementName = "remark")]
        public string Remark { get; set; }
    }
    [Serializable]
    public class EntryOrder
    {
        [XmlElement(ElementName = "entryOrderCode")]
        public string EntryOrderCode { get; set; }

        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }
        [XmlElement(ElementName = "warehouseCode")]
        public string WarehouseCode { get; set; }
        [XmlElement(ElementName = "entryOrderId")]
        public string EntryOrderId { get; set; }
        [XmlElement(ElementName = "entryOrderType")]
        public string EntryOrderType { get; set; }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "operateTime")]
        public string OperateTime { get; set; }
    }
}