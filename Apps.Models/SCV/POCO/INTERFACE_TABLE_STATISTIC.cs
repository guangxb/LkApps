//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
	public partial class INTERFACE_TABLE_STATISTIC
	{
		public Apps.Models.SCV.INTERFACE.INTERFACE_TABLE_STATISTIC_MODEL ToPOCO(){
			return new Apps.Models.SCV.INTERFACE.INTERFACE_TABLE_STATISTIC_MODEL(){
								FUNCTION_AREA=this.FUNCTION_AREA,
				FROM_TABLE=this.FROM_TABLE,
				TO_TABLE=this.TO_TABLE,
				DIRECTION=this.DIRECTION,
				FROM_STATISTIC_SQL=this.FROM_STATISTIC_SQL,
				TO_STATISTIC_SQL=this.TO_STATISTIC_SQL,
				LINK_FIELD=this.LINK_FIELD,
				USER=this.USER,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				ACTIVE=this.ACTIVE,
			};
		}
	}
}
