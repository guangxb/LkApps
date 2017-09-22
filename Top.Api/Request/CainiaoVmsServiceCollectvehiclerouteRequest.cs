using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.vms.service.collectvehicleroute
    /// </summary>
    public class CainiaoVmsServiceCollectvehiclerouteRequest : BaseTopRequest<Top.Api.Response.CainiaoVmsServiceCollectvehiclerouteResponse>
    {
        /// <summary>
        /// 数据 采集时间
        /// </summary>
        public Nullable<DateTime> ColDate { get; set; }

        /// <summary>
        /// cp编码
        /// </summary>
        public string CpCode { get; set; }

        /// <summary>
        /// 车辆唯一标识号
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string VechileNumber { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.vms.service.collectvehicleroute";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("col_date", this.ColDate);
            parameters.Add("cp_code", this.CpCode);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("latitude", this.Latitude);
            parameters.Add("longitude", this.Longitude);
            parameters.Add("vechile_number", this.VechileNumber);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("col_date", this.ColDate);
            RequestValidator.ValidateRequired("cp_code", this.CpCode);
            RequestValidator.ValidateRequired("latitude", this.Latitude);
            RequestValidator.ValidateRequired("longitude", this.Longitude);
            RequestValidator.ValidateRequired("vechile_number", this.VechileNumber);
        }

        #endregion
    }
}
