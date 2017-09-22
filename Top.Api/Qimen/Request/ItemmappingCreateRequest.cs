using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.itemmapping.create
    /// </summary>
    public class ItemmappingCreateRequest : QimenRequest<Qimen.Api.Response.ItemmappingCreateResponse>
    {
        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string ItemSource { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string ShopItemId { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string ShopNick { get; set; }

        /// <summary>
        /// 奇门仓储字段,C123,string(50),必填,
        /// </summary>
        public string SkuId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.itemmapping.create";
        }


        #endregion
    }
}
