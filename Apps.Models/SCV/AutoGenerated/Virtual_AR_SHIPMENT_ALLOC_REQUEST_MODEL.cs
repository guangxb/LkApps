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
	public class Virtual_AR_SHIPMENT_ALLOC_REQUEST_MODEL
	{
			public virtual decimal INTERNAL_SHIP_ALLOC_NUM { get; set; }
			public virtual decimal INTERNAL_SHIPMENT_LINE_NUM { get; set; }
			public virtual decimal INTERNAL_SHIPMENT_NUM { get; set; }
			public virtual string SHIPMENT_ID { get; set; }
			public virtual string SHIPMENT_TYPE { get; set; }
			public virtual Nullable<decimal> PRIORITY { get; set; }
			public virtual string WAREHOUSE { get; set; }
			public virtual string ITEM { get; set; }
			public virtual string COMPANY { get; set; }
			public virtual string ITEM_DESC { get; set; }
			public virtual Nullable<decimal> REQUESTED_QTY { get; set; }
			public virtual Nullable<decimal> ALLOCATED_QTY { get; set; }
			public virtual string QUANTITY_UM { get; set; }
			public virtual Nullable<decimal> ATTRIBUTE_NUM { get; set; }
			public virtual string FROM_LOC { get; set; }
			public virtual string TO_LOC { get; set; }
			public virtual string FROM_ZONE { get; set; }
			public virtual string TO_ZONE { get; set; }
			public virtual string FROM_LPN { get; set; }
			public virtual string FROM_PARENT_LPN { get; set; }
			public virtual string CUSTOMER { get; set; }
			public virtual string SHIP_TO { get; set; }
			public virtual decimal INTERNAL_WAVE_NUM { get; set; }
			public virtual string PACKING_CLASS { get; set; }
			public virtual string USER_DEF1 { get; set; }
			public virtual string USER_DEF2 { get; set; }
			public virtual string USER_DEF3 { get; set; }
			public virtual string USER_DEF4 { get; set; }
			public virtual string USER_DEF5 { get; set; }
			public virtual string USER_DEF6 { get; set; }
			public virtual string USER_DEF7 { get; set; }
			public virtual string USER_DEF8 { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual Nullable<System.DateTime> DATE_TIME_STAMP { get; set; }
			public virtual Nullable<decimal> CONVERTED_ALLOC_QTY { get; set; }
			public virtual string CONVERTED_QTY_UM { get; set; }
			public virtual string FROM_TEMPL_FIELD1 { get; set; }
			public virtual string FROM_TEMPL_FIELD2 { get; set; }
			public virtual string FROM_TEMPL_FIELD3 { get; set; }
			public virtual string FROM_TEMPL_FIELD4 { get; set; }
			public virtual string FROM_TEMPL_FIELD5 { get; set; }
			public virtual string TO_TEMPL_FIELD1 { get; set; }
			public virtual string TO_TEMPL_FIELD2 { get; set; }
			public virtual string TO_TEMPL_FIELD3 { get; set; }
			public virtual string TO_TEMPL_FIELD4 { get; set; }
			public virtual string TO_TEMPL_FIELD5 { get; set; }
			public virtual string TASK_CREATED { get; set; }
			public virtual string TREAT_AS_LOOSE { get; set; }
			public virtual string INVENTORY_STS { get; set; }
			public virtual string REPLENISHMENT_REQD { get; set; }
			public virtual Nullable<decimal> CONTAINER_WEIGHT { get; set; }
			public virtual Nullable<decimal> CONTAINER_HEIGHT { get; set; }
			public virtual Nullable<decimal> CONTAINER_WIDTH { get; set; }
			public virtual Nullable<decimal> CONTAINER_LENGTH { get; set; }
			public virtual string DIMENSION_UM { get; set; }
			public virtual string WEIGHT_UM { get; set; }
			public virtual Nullable<decimal> ITEM_LENGTH { get; set; }
			public virtual Nullable<decimal> ITEM_WIDTH { get; set; }
			public virtual Nullable<decimal> ITEM_HEIGHT { get; set; }
			public virtual Nullable<decimal> ITEM_WEIGHT { get; set; }
		}
}
