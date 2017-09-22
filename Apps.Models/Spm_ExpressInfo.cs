//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spm_ExpressInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Spm_ExpressInfo()
        {
            this.Spm_TracesInfo = new HashSet<Spm_TracesInfo>();
        }
    
        public string Id { get; set; }
        public Nullable<System.DateTime> ActualShipDateTime { get; set; }
        public string ShipmentId { get; set; }
        public Nullable<System.DateTime> DateTimeStamp { get; set; }
        public string TrackingNumber { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public string ShipperCode { get; set; }
        public string CallBack { get; set; }
        public string EBusinessID { get; set; }
        public string OrderCode { get; set; }
        public string Reason { get; set; }
        public Nullable<bool> Success { get; set; }
        public Nullable<System.DateTime> PushTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spm_TracesInfo> Spm_TracesInfo { get; set; }
    }
}
