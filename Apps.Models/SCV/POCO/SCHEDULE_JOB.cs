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
	public partial class SCHEDULE_JOB
	{
		public Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_MODEL ToPOCO(){
			return new Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_MODEL(){
								JOB_NAME=this.JOB_NAME,
				JOB_GROUP=this.JOB_GROUP,
				DESCRIPTION=this.DESCRIPTION,
				IS_DURABLE=this.IS_DURABLE,
				IS_NONCONCURRENT=this.IS_NONCONCURRENT,
				IS_UPDATE_DATA=this.IS_UPDATE_DATA,
				REQUESTS_RECOVERY=this.REQUESTS_RECOVERY,
				JOB_TYPE=this.JOB_TYPE,
				CRON_EXPRESSION=this.CRON_EXPRESSION,
				NEXT_FIRE_TIME=this.NEXT_FIRE_TIME,
				PREV_FIRE_TIME=this.PREV_FIRE_TIME,
				ACTIVE=this.ACTIVE,
				SYSTEM_CREATED=this.SYSTEM_CREATED,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				PROCESS_STAMP=this.PROCESS_STAMP,
				PARA1_VALUE=this.PARA1_VALUE,
				PARA2_VALUE=this.PARA2_VALUE,
				PARA3_VALUE=this.PARA3_VALUE,
				PARA4_VALUE=this.PARA4_VALUE,
				PARA5_VALUE=this.PARA5_VALUE,
				PARA6_VALUE=this.PARA6_VALUE,
				PARA7_VALUE=this.PARA7_VALUE,
				PARA8_VALUE=this.PARA8_VALUE,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				JOB_STATUS=this.JOB_STATUS,
				RUNNED=this.RUNNED,
			};
		}
	}
}
