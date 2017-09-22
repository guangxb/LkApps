using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.SingleitemSynchronizeModel
{
    public class SingleitemSynchronizeModel
    {
    }

    [XmlRoot("request", IsNullable = false)]
    public class SingleitemSynchronizeRequestModel
    {
        [XmlElement(ElementName = "actionType")]
        public string ActionType { get; set; }
        [XmlElement(ElementName = "wareHouseCode")]
        public string WareHouseCode { get; set; }
        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }
        [XmlElement(ElementName = "item")]
        public Item Item { get; set; }

    }

    public class Item
    {
        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "itemName")]
        public string ItemName { get; set; }
        [XmlElement(ElementName = "barCode")]
        public string BarCode { get; set; }
        [XmlElement(ElementName = "itemType")]
        public string ItemType { get; set; }

        [XmlElement(ElementName = "length")]
        public decimal Length { get; set; }
        [XmlElement(ElementName = "width")]
        public decimal Width { get; set; }
        [XmlElement(ElementName = "height")]
        public decimal Height { get; set; }
        [XmlElement(ElementName = "grossWeight")]
        public decimal GrossWeight { get; set; }
        [XmlElement(ElementName = "goodsCode")]
        public string GoodsCode { get; set; }
        [XmlElement(ElementName = "color")]
        public string Color { get; set; }
        //skuProperty商品属性
        [XmlElement(ElementName = "skuProperty")]
        public string SkuProperty { get; set; }

    }
    [XmlRoot("response", IsNullable = false)]
    public class SingleitemSynchronizeResponseModel
    {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }

        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        [XmlElement(ElementName = "itemId")]
        public string ItemId { get; set; }
    }
}