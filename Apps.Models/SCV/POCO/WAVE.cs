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
	public partial class WAVE
	{
		public Apps.Models.SCV.Sys.WAVE_MODEL ToPOCO(){
			return new Apps.Models.SCV.Sys.WAVE_MODEL(){
								INTERNAL_WAVE_NUM=this.INTERNAL_WAVE_NUM,
				WAREHOUSE=this.WAREHOUSE,
				WAVE_NAME=this.WAVE_NAME,
				WAVE_MASTER=this.WAVE_MASTER,
				STATUS=this.STATUS,
				CURRENT_WAVE_STEP=this.CURRENT_WAVE_STEP,
				LAST_WAVE_STEP=this.LAST_WAVE_STEP,
				TOTAL_SHIPMENTS=this.TOTAL_SHIPMENTS,
				TOTAL_LINES=this.TOTAL_LINES,
				TOTAL_QTY=this.TOTAL_QTY,
				QUANTITY_UM=this.QUANTITY_UM,
				WAVE_DATE_TIME_STARTED=this.WAVE_DATE_TIME_STARTED,
				WAVE_DATE_TIME_ENDED=this.WAVE_DATE_TIME_ENDED,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				WAVE_MODE=this.WAVE_MODE,
				ERROR_MESSAGE=this.ERROR_MESSAGE,
				LOCKED=this.LOCKED,
				REPLENISHMENT_REQD=this.REPLENISHMENT_REQD,
				PROCESS_STAMP=this.PROCESS_STAMP,
				MESSAGE_ID=this.MESSAGE_ID,
				RUN_USER=this.RUN_USER,
				RELESAE_USER=this.RELESAE_USER,
				RELESAE_DATE_TIME=this.RELESAE_DATE_TIME,
				PRINT=this.PRINT,
			};
		}
	}
}