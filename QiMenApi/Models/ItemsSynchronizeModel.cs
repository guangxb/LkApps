using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QiMenApi.Models.ItemsSynchronizeModel
{
    
    public class ItemsSynchronizeModel
    {
         
    }
    [XmlRoot("request", IsNullable = false)]
    public class ItemsSynchronizeRequestModel
    {
        [XmlElement(ElementName = "actionType")]
        public string ActionType { get; set; }
        [XmlElement(ElementName = "wareHouseCode")]
        public string WareHouseCode { get; set; }
        [XmlElement(ElementName = "ownerCode")]
        public string OwnerCode { get; set; }

        [XmlArray(ElementName = "items"), XmlArrayItem(ElementName = "item")]
        public List<Item> Items { get; set; }
    }

    public class Item {
        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "itemName")]
        public string ItemName { get; set; }
        [XmlElement(ElementName = "barCode")]
        public string BarCode { get; set; }
        [XmlElement(ElementName = "itemType")]
        public string ItemType { get; set; }
    }
    [XmlRoot("response", IsNullable = false)]
    public class ItemsSynchronizeResponseModel {
        [XmlElement(ElementName = "flag")]
        public string Flag { get; set; }

        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        [XmlArray(ElementName = "items"), XmlArrayItem(ElementName = "BatchItemSynItem")]
        public List<BatchItemSynItem> Items { get;set;}
    }

    public class BatchItemSynItem {
        [XmlElement(ElementName = "itemCode")]
        public string ItemCode { get; set; }
        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
    }
}