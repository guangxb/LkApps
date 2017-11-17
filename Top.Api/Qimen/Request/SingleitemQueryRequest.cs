using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.singleitem.query
    /// </summary>
    /// 

    [XmlRoot("request", Namespace = "", IsNullable = false)]
    public class SingleitemQueryRequest : QimenRequest<Qimen.Api.Response.SingleitemQueryResponse>
    {

        [XmlElement("itemCode")]
        /// <summary>
        /// 商品编码,S1234,string(50),必填,
        /// </summary>
        public string ItemCode { get; set; }

        [XmlElement("itemId")]
        /// <summary>
        /// 仓储系统商品编码,C123,string(50),必填,
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 货主编码,H123,string(50),必填,
        /// </summary>
        /// 
        [XmlElement("ownerCode")]
        public string OwnerCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.singleitem.query";
        }


        #endregion
    }
}
