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
	public partial class MESSAGE
	{
		public Apps.Models.SCV.Sys.MESSAGE_MODEL ToPOCO(){
			return new Apps.Models.SCV.Sys.MESSAGE_MODEL(){
								MESSAGE_ID=this.MESSAGE_ID,
				MESSAGE_TYPE=this.MESSAGE_TYPE,
				SUB_TYPE=this.SUB_TYPE,
				PRIORITY=this.PRIORITY,
				SRC_END_POINT=this.SRC_END_POINT,
				DST_END_POINT=this.DST_END_POINT,
				STATUS=this.STATUS,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				PROCESS_STAMP=this.PROCESS_STAMP,
				ACTIVE=this.ACTIVE,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				MESSAGE_BODY=this.MESSAGE_BODY,
			};
		}
	}
}