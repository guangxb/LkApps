using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace Qimen.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.transferorder.query
    /// </summary>
    public class TransferorderQueryRequest : QimenRequest<Qimen.Api.Response.TransferorderQueryResponse>
    {
        /// <summary>
        /// 111
        /// </summary>
        public string OwnerCode { get; set; }

        /// <summary>
        /// 调拨单号
        /// </summary>
        public string TransferOrderCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.transferorder.query";
        }


        #endregion
    }
}
