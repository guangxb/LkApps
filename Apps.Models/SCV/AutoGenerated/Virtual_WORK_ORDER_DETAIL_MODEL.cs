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
namespace Apps.Models.SCV.WORK
{
	public class Virtual_WORK_ORDER_DETAIL_MODEL
	{
			public virtual decimal INTERNAL_NUM { get; set; }
			public virtual decimal INTERNAL_WORK_ORDER_NUM { get; set; }
			public virtual string WAREHOUSE { get; set; }
			public virtual string ITEM { get; set; }
			public virtual string COMPANY { get; set; }
			public virtual decimal BUILD_SEQ { get; set; }
			public virtual decimal BUILD_LEVEL { get; set; }
			public virtual decimal QTY_NEEDED_PER_ITEM { get; set; }
			public virtual Nullable<decimal> TOTAL_QTY_NEEDED { get; set; }
			public virtual Nullable<decimal> TOTAL_QTY_USED { get; set; }
			public virtual string QUANTITY_UM { get; set; }
			public virtual string FROM_LOC { get; set; }
			public virtual string ALLOCATION_RULE { get; set; }
			public virtual Nullable<decimal> INTERNAL_WAVE_NUM { get; set; }
			public virtual string TASK_CREATED { get; set; }
			public virtual string ALLOCATED { get; set; }
			public virtual Nullable<decimal> TOTAL_CONVERTED_QTY_NEEDED { get; set; }
			public virtual string CONVERTED_UM { get; set; }
			public virtual string ITEM_DESC { get; set; }
			public virtual string IN_ALLOCATION { get; set; }
			public virtual Nullable<decimal> ATTRIBUTE_NUM { get; set; }
			public virtual string ATTRIBUTE1 { get; set; }
			public virtual string ATTRIBUTE2 { get; set; }
			public virtual string ATTRIBUTE3 { get; set; }
			public virtual string ATTRIBUTE4 { get; set; }
			public virtual string ATTRIBUTE5 { get; set; }
			public virtual string ATTRIBUTE6 { get; set; }
			public virtual string ATTRIBUTE7 { get; set; }
			public virtual string ATTRIBUTE8 { get; set; }
			public virtual string LPN { get; set; }
			public virtual string PARENT_LPN { get; set; }
			public virtual string USER_DEF1 { get; set; }
			public virtual string USER_DEF2 { get; set; }
			public virtual string USER_DEF3 { get; set; }
			public virtual string USER_DEF4 { get; set; }
			public virtual string USER_DEF5 { get; set; }
			public virtual string USER_DEF6 { get; set; }
			public virtual string USER_DEF7 { get; set; }
			public virtual string USER_DEF8 { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual string PROCESS_STAMP { get; set; }
			public virtual System.DateTime CREATED_DATE_TIME { get; set; }
		}
}