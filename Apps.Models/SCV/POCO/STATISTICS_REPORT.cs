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
	public partial class STATISTICS_REPORT
	{
		public Apps.Models.SCV.STATISTICS.STATISTICS_REPORT_MODEL ToPOCO(){
			return new Apps.Models.SCV.STATISTICS.STATISTICS_REPORT_MODEL(){
								ACTIVITY_DATE=this.ACTIVITY_DATE,
				IN_CONTAINERS=this.IN_CONTAINERS,
				OUT_CONTAINERS=this.OUT_CONTAINERS,
				IN_ORDERS=this.IN_ORDERS,
				OUT_ORDERS=this.OUT_ORDERS,
				IN_QTY=this.IN_QTY,
				OUT_QTY=this.OUT_QTY,
				COMPANY=this.COMPANY,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				USER_STAMP=this.USER_STAMP,
				INTERNAL_NUM=this.INTERNAL_NUM,
			};
		}
	}
}