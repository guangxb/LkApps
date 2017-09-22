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
    
    public partial class SHIPMENT_HEADER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHIPMENT_HEADER()
        {
            this.SHIPMENT_ALLOC_REQUEST = new HashSet<SHIPMENT_ALLOC_REQUEST>();
            this.SHIPMENT_DETAIL = new HashSet<SHIPMENT_DETAIL>();
            this.SHIPPING_CONTAINER = new HashSet<SHIPPING_CONTAINER>();
            this.SHIPPING_CONTAINER1 = new HashSet<SHIPPING_CONTAINER>();
        }
    
        public decimal INTERNAL_SHIPMENT_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public Nullable<decimal> INTERNAL_LOAD_NUM { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string ERP_ORDER { get; set; }
        public decimal LEADING_STS { get; set; }
        public Nullable<decimal> TRAILING_STS { get; set; }
        public string SHIPMENT_TYPE { get; set; }
        public string ROUTE { get; set; }
        public string SHIP_TO { get; set; }
        public string SHIP_TO_NAME { get; set; }
        public string SHIP_TO_ADDRESS1 { get; set; }
        public string SHIP_TO_ADDRESS2 { get; set; }
        public string SHIP_TO_DISTRICT { get; set; }
        public string SHIP_TO_CITY { get; set; }
        public string SHIP_TO_STATE { get; set; }
        public string SHIP_TO_COUNTRY { get; set; }
        public string SHIP_TO_POSTAL_CODE { get; set; }
        public string SHIP_TO_ATTENTION_TO { get; set; }
        public string SHIP_TO_PHONE_NUM { get; set; }
        public string SHIP_TO_MOBILE { get; set; }
        public string SHIP_TO_FAX_NUM { get; set; }
        public string SHIP_TO_EMAIL_ADDRESS { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public string USER_STAMP { get; set; }
        public Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
        public Nullable<System.DateTime> REQUESTED_DELIVERY_DATE { get; set; }
        public string REQUESTED_DELIVERY_TYPE { get; set; }
        public Nullable<System.DateTime> SCHEDULED_SHIP_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_SHIP_DATE_TIME { get; set; }
        public Nullable<System.DateTime> ACTUAL_DELIVERY_DATE_TIME { get; set; }
        public string DELIVERY_NOTE { get; set; }
        public string REJECTION_NOTE { get; set; }
        public Nullable<decimal> INTERNAL_WAVE_NUM { get; set; }
        public string SHIP_DOCK { get; set; }
        public string ALLOCATE_COMPLETE { get; set; }
        public Nullable<decimal> TOTAL_WEIGHT { get; set; }
        public string WEIGHT_UM { get; set; }
        public Nullable<decimal> TOTAL_VOLUME { get; set; }
        public string VOLUME_UM { get; set; }
        public Nullable<decimal> TOTAL_LINES { get; set; }
        public Nullable<decimal> TOTAL_CONTAINERS { get; set; }
        public string CARRIER { get; set; }
        public string CARRIER_SERVICE { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public Nullable<decimal> USER_DEF9 { get; set; }
        public Nullable<decimal> USER_DEF10 { get; set; }
        public Nullable<decimal> BACK_ORDER_NUM { get; set; }
        public string PROCESS_TYPE { get; set; }
        public Nullable<decimal> TOTAL_QTY { get; set; }
        public Nullable<decimal> LAST_WAVE_NUM { get; set; }
        public Nullable<decimal> GROUP_NUM { get; set; }
        public Nullable<decimal> GROUP_INDEX { get; set; }
        public string SIGN_VALUE { get; set; }
        public string SHIPMENT_SUB_TYPE { get; set; }
        public string SHIPMENT_CATEGORY1 { get; set; }
        public string SHIPMENT_CATEGORY2 { get; set; }
        public string SHIPMENT_CATEGORY3 { get; set; }
        public string SHIPMENT_CATEGORY4 { get; set; }
        public string SHIPMENT_CATEGORY5 { get; set; }
        public string SHIPMENT_CATEGORY6 { get; set; }
        public string SHIPMENT_CATEGORY7 { get; set; }
        public string SHIPMENT_CATEGORY8 { get; set; }
        public string UPLOAD_INTERFACE_FLAG { get; set; }
        public Nullable<decimal> TOTAL_VALUE { get; set; }
        public string SHIPMENT_NOTE { get; set; }
        public Nullable<decimal> STOP_SEQ { get; set; }
        public Nullable<System.DateTime> CREATE_DATE_TIME { get; set; }
        public string CREATE_USER { get; set; }
        public string COD_REQUIRED { get; set; }
        public Nullable<decimal> COD_VALUE { get; set; }
        public string DEIVERY_WINDOW { get; set; }
        public string ALLOW_CONSOLIDATE { get; set; }
        public string CONSOLIDATED { get; set; }
        public string INVOICE_REQUIRED { get; set; }
        public Nullable<decimal> INTERNAL_INVOICE_NUM { get; set; }
        public string HOST_COMPANY { get; set; }
        public Nullable<System.DateTime> UPLOAD_INTERFACE_DATE_TIME { get; set; }
        public string UPLOAD_INTERFACE_REQUIRED { get; set; }
        public string SO_OPERATOR { get; set; }
        public string SO_OPERATOR_PHONE_NUM { get; set; }
        public string SO_EMAIL_ADDRESS { get; set; }
        public string STATUS_FLOW { get; set; }
        public string ITF_USERDEF1 { get; set; }
        public string ITF_USERDEF2 { get; set; }
        public string ITF_USERDEF3 { get; set; }
        public string ITF_USERDEF4 { get; set; }
        public string ITF_USERDEF5 { get; set; }
        public string ITF_USERDEF6 { get; set; }
        public string ITF_USERDEF7 { get; set; }
        public string ITF_USERDEF8 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENT_ALLOC_REQUEST> SHIPMENT_ALLOC_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENT_DETAIL> SHIPMENT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPPING_CONTAINER> SHIPPING_CONTAINER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPPING_CONTAINER> SHIPPING_CONTAINER1 { get; set; }
    }
}
