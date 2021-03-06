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
namespace Apps.Models.SCV.TRANSFER
{
	public class Virtual_TRANSFER_ORDER_DETAIL_MODEL
	{
			public virtual decimal INTERNAL_TRANSFER_LINE_NUM { get; set; }
			public virtual decimal INTERNAL_TRANSFER_NUM { get; set; }
			public virtual string TRANSFER_ID { get; set; }
			public virtual Nullable<decimal> LINE_NUM { get; set; }
			public virtual string WAREHOUSE { get; set; }
			public virtual string FROM_LOC { get; set; }
			public virtual string TO_LOC { get; set; }
			public virtual string COMPANY { get; set; }
			public virtual string ITEM { get; set; }
			public virtual string ITEM_DESC { get; set; }
			public virtual string FROM_LPN { get; set; }
			public virtual string TO_LPN { get; set; }
			public virtual Nullable<decimal> TOTAL_QTY { get; set; }
			public virtual Nullable<decimal> FROM_QTY { get; set; }
			public virtual Nullable<decimal> TO_QTY { get; set; }
			public virtual string QUANTITY_UM { get; set; }
			public virtual Nullable<System.DateTime> BEGIN_DATE_TIME { get; set; }
			public virtual Nullable<System.DateTime> END_DATE_TIME { get; set; }
			public virtual Nullable<decimal> ATTRIBUTE_NUM { get; set; }
			public virtual string INVENTORY_STS { get; set; }
			public virtual string LOCATING_RULE { get; set; }
			public virtual string CREATED_USER { get; set; }
			public virtual Nullable<System.DateTime> CREATED_DATE_TIME { get; set; }
			public virtual string LAST_MODIFIED_USER { get; set; }
			public virtual Nullable<System.DateTime> LAST_MODIFIED_DATE_TIME { get; set; }
			public virtual string USER_DEF1 { get; set; }
			public virtual string USER_DEF2 { get; set; }
			public virtual string USER_DEF3 { get; set; }
			public virtual string USER_DEF4 { get; set; }
			public virtual string USER_DEF5 { get; set; }
			public virtual string USER_DEF6 { get; set; }
			public virtual string USER_DEF7 { get; set; }
			public virtual string USER_DEF8 { get; set; }
			public virtual string CART_ID { get; set; }
			public virtual string CART_POS { get; set; }
			public virtual Nullable<decimal> STATUS { get; set; }
			public virtual string ATTRIBUTE1 { get; set; }
			public virtual string ATTRIBUTE2 { get; set; }
			public virtual string ATTRIBUTE3 { get; set; }
			public virtual string ATTRIBUTE4 { get; set; }
			public virtual string ATTRIBUTE5 { get; set; }
			public virtual string ATTRIBUTE6 { get; set; }
			public virtual string ATTRIBUTE7 { get; set; }
			public virtual string ATTRIBUTE8 { get; set; }
			public virtual string PARENT_LPN { get; set; }
			public virtual string REFERENCE_ID { get; set; }
			public virtual Nullable<decimal> REFERENCE_NUM { get; set; }
			public virtual string REFERENCE_NUM_TYPE { get; set; }
			public virtual Nullable<decimal> REFERENCE_LINE_NUM { get; set; }
			public virtual string PROCESS_STAMP { get; set; }
			public virtual string UPLOAD_INTERFACE_FLAG { get; set; }
		}
}
