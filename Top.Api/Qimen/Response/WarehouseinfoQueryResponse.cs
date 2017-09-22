using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace Qimen.Api.Response
{
    /// <summary>
    /// WarehouseinfoQueryResponse.
    /// </summary>
    public class WarehouseinfoQueryResponse : QimenResponse
    {
        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlElement("ownerCode")]
        public string OwnerCode { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlElement("ownerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 奇门仓储字段
        /// </summary>
        [XmlArray("warehouseInfos")]
        [XmlArrayItem("warehouse_info")]
        public List<WarehouseInfoDomain> WarehouseInfos { get; set; }

	/// <summary>
/// WarehouseInfoDomain Data Structure.
/// </summary>
[Serializable]

public class WarehouseInfoDomain : TopObject
{
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("area")]
	        public string Area { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("detailAddress")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("tel")]
	        public string Tel { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("town")]
	        public string Town { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("warehouseCode")]
	        public string WarehouseCode { get; set; }
	
	        /// <summary>
	        /// 奇门仓储字段
	        /// </summary>
	        [XmlElement("warehouseName")]
	        public string WarehouseName { get; set; }
}

    }
}
