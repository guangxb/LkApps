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
	public partial class INTERFACE_PROCESS
	{
		public Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL ToPOCO(){
			return new Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				DESCRIPTION=this.DESCRIPTION,
				INTERFACE_TYPE=this.INTERFACE_TYPE,
				DIRECTION=this.DIRECTION,
				INTERFACE_MODE=this.INTERFACE_MODE,
				PRE_INTERFACE_ACTION=this.PRE_INTERFACE_ACTION,
				POST_INTERFACE_ACTION=this.POST_INTERFACE_ACTION,
				INTERFACE_ACTION=this.INTERFACE_ACTION,
				SAVE_DATA=this.SAVE_DATA,
				TRANSACTION_SIZE=this.TRANSACTION_SIZE,
				ACTIVE=this.ACTIVE,
				IN_PROCESS=this.IN_PROCESS,
				LAST_RUN_TIME=this.LAST_RUN_TIME,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				USER_STAMP=this.USER_STAMP,
				LAST_RUN_RESULT=this.LAST_RUN_RESULT,
			};
		}
	}
}
