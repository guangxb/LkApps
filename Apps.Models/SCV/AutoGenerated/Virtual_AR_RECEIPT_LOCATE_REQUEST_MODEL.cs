//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.SCV.AR
{
	public class Virtual_AR_RECEIPT_LOCATE_REQUEST_MODEL
	{
			public virtual decimal INTERNAL_REC_LOC_NUM { get; set; }
			public virtual string WAREHOUSE { get; set; }
			public virtual string COMPANY { get; set; }
			public virtual Nullable<decimal> INTERNAL_CONTAINER_NUM { get; set; }
			public virtual string CONTAINER_ID { get; set; }
			public virtual string ITEM { get; set; }
			public virtual string ITEM_DESC { get; set; }
			public virtual decimal LOCATE_QTY { get; set; }
			public virtual string QUANTITY_UM { get; set; }
			public virtual Nullable<decimal> ATTRIBUTE_NUM { get; set; }
			public virtual string INVENTORY_STS { get; set; }
			public virtual string FROM_LOC { get; set; }
			public virtual string TO_LOC { get; set; }
			public virtual string FROM_TEMPLATE_FIELD1 { get; set; }
			public virtual string FROM_TEMPLATE_FIELD2 { get; set; }
			public virtual string FROM_TEMPLATE_FIELD3 { get; set; }
			public virtual string FROM_TEMPLATE_FIELD4 { get; set; }
			public virtual string FROM_TEMPLATE_FIELD5 { get; set; }
			public virtual string TO_TEMPLATE_FIELD1 { get; set; }
			public virtual string TO_TEMPLATE_FIELD2 { get; set; }
			public virtual string TO_TEMPLATE_FIELD3 { get; set; }
			public virtual string TO_TEMPLATE_FIELD4 { get; set; }
			public virtual string TO_TEMPLATE_FIELD5 { get; set; }
			public virtual string ZONE { get; set; }
			public virtual Nullable<decimal> CONVERTED_QTY { get; set; }
			public virtual string CONVERTED_QTY_UM { get; set; }
			public virtual string TASK_CREATED { get; set; }
			public virtual string RECEIPT_ID { get; set; }
			public virtual string RECEIPT_TYPE { get; set; }
			public virtual Nullable<System.DateTime> RECEIPT_DATE { get; set; }
			public virtual Nullable<decimal> PARENT_CONTAINER_NUM { get; set; }
			public virtual string PARENT_CONTAINER_ID { get; set; }
			public virtual Nullable<decimal> INTERNAL_RECEIPT_NUM { get; set; }
			public virtual Nullable<decimal> INTERNAL_RECEIPT_LINE_NUM { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
			public virtual Nullable<decimal> INTERNAL_WAVE_NUM { get; set; }
		}
}
