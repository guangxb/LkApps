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
	public partial class WORK_ORDER_HEADER
	{
		public Apps.Models.SCV.WORK.WORK_ORDER_HEADER_MODEL ToPOCO(){
			return new Apps.Models.SCV.WORK.WORK_ORDER_HEADER_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				WAREHOUSE=this.WAREHOUSE,
				COMPANY=this.COMPANY,
				ITEM=this.ITEM,
				ITEM_DESC=this.ITEM_DESC,
				REVISION_NUM=this.REVISION_NUM,
				WORK_ORDER_ID=this.WORK_ORDER_ID,
				BUILD_LOC=this.BUILD_LOC,
				TOTAL_QTY=this.TOTAL_QTY,
				OPEN_QTY=this.OPEN_QTY,
				BUILT_QTY=this.BUILT_QTY,
				QTY_UM=this.QTY_UM,
				DUE_DATE=this.DUE_DATE,
				CREATED_DATE_TIME=this.CREATED_DATE_TIME,
				RELEASED_DATE_TIME=this.RELEASED_DATE_TIME,
				COMPLETION_DATE_TIME=this.COMPLETION_DATE_TIME,
				PLANNED_UNIT_BUILD_TIME=this.PLANNED_UNIT_BUILD_TIME,
				MANUALLY_ENTERED=this.MANUALLY_ENTERED,
				BUILD_INSTRUCTIONS=this.BUILD_INSTRUCTIONS,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				USER_STAMP=this.USER_STAMP,
				PROCESS_STAMP=this.PROCESS_STAMP,
				LAST_MODIFIED_DATE_TIME=this.LAST_MODIFIED_DATE_TIME,
				IN_ALLOCATION=this.IN_ALLOCATION,
				CONDITION=this.CONDITION,
				ALLOC_ATTEMPTED=this.ALLOC_ATTEMPTED,
				IN_CONFIRMATION=this.IN_CONFIRMATION,
			};
		}
	}
}
