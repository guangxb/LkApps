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
    
    public partial class AR_RECEIPT_LOCATE_REQUEST
    {
        public decimal INTERNAL_REC_LOC_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string COMPANY { get; set; }
        public Nullable<decimal> INTERNAL_CONTAINER_NUM { get; set; }
        public string CONTAINER_ID { get; set; }
        public string ITEM { get; set; }
        public string ITEM_DESC { get; set; }
        public decimal LOCATE_QTY { get; set; }
        public string QUANTITY_UM { get; set; }
        public Nullable<decimal> ATTRIBUTE_NUM { get; set; }
        public string INVENTORY_STS { get; set; }
        public string FROM_LOC { get; set; }
        public string TO_LOC { get; set; }
        public string FROM_TEMPLATE_FIELD1 { get; set; }
        public string FROM_TEMPLATE_FIELD2 { get; set; }
        public string FROM_TEMPLATE_FIELD3 { get; set; }
        public string FROM_TEMPLATE_FIELD4 { get; set; }
        public string FROM_TEMPLATE_FIELD5 { get; set; }
        public string TO_TEMPLATE_FIELD1 { get; set; }
        public string TO_TEMPLATE_FIELD2 { get; set; }
        public string TO_TEMPLATE_FIELD3 { get; set; }
        public string TO_TEMPLATE_FIELD4 { get; set; }
        public string TO_TEMPLATE_FIELD5 { get; set; }
        public string ZONE { get; set; }
        public Nullable<decimal> CONVERTED_QTY { get; set; }
        public string CONVERTED_QTY_UM { get; set; }
        public string TASK_CREATED { get; set; }
        public string RECEIPT_ID { get; set; }
        public string RECEIPT_TYPE { get; set; }
        public Nullable<System.DateTime> RECEIPT_DATE { get; set; }
        public Nullable<decimal> PARENT_CONTAINER_NUM { get; set; }
        public string PARENT_CONTAINER_ID { get; set; }
        public Nullable<decimal> INTERNAL_RECEIPT_NUM { get; set; }
        public Nullable<decimal> INTERNAL_RECEIPT_LINE_NUM { get; set; }
        public string USER_STAMP { get; set; }
        public Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
        public Nullable<decimal> INTERNAL_WAVE_NUM { get; set; }
    }
}
