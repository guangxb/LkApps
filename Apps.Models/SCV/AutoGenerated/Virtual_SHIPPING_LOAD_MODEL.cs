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
namespace Apps.Models.SCV.SHIPPING
{
	public class Virtual_SHIPPING_LOAD_MODEL
	{
			public virtual decimal INTERNAL_LOAD_NUM { get; set; }
			public virtual string WAREHOUSE { get; set; }
			public virtual decimal TRAILING_STS { get; set; }
			public virtual Nullable<decimal> LEADING_STS { get; set; }
			public virtual string CARRIER { get; set; }
			public virtual string CARRIER_SERVICE { get; set; }
			public virtual Nullable<System.DateTime> SCHEDULED_SHIP_DATE { get; set; }
			public virtual Nullable<System.DateTime> ACTUAL_SHIP_DATE { get; set; }
			public virtual string LOAD_SIZE_DEF { get; set; }
			public virtual string LOAD_CLOSED { get; set; }
			public virtual string SEAL_ID { get; set; }
			public virtual string TRAILER_ID { get; set; }
			public virtual Nullable<decimal> TOTAL_SHIPMENTS { get; set; }
			public virtual Nullable<decimal> TOTAL_CONTAINERS { get; set; }
			public virtual Nullable<decimal> TOTAL_WEIGHT { get; set; }
			public virtual string WEIGHT_UM { get; set; }
			public virtual Nullable<decimal> TOTAL_VOLUME { get; set; }
			public virtual string VOLUME_UM { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual System.DateTime DATE_TIME_STAMP { get; set; }
			public virtual string ROUTE { get; set; }
			public virtual string DOCK_DOOR { get; set; }
			public virtual string DRIVER { get; set; }
			public virtual Nullable<decimal> MAX_WEIGHT { get; set; }
			public virtual Nullable<decimal> MAX_VOLUME { get; set; }
			public virtual string USER_DEF1 { get; set; }
			public virtual string USER_DEF2 { get; set; }
			public virtual string USER_DEF3 { get; set; }
			public virtual string USER_DEF4 { get; set; }
			public virtual string USER_DEF5 { get; set; }
			public virtual string USER_DEF6 { get; set; }
			public virtual string USER_DEF7 { get; set; }
			public virtual string USER_DEF8 { get; set; }
			public virtual string IN_CONFIRM { get; set; }
		}
}
