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
	public partial class WAREHOUSE
	{
		public Apps.Models.SCV.Sys.WAREHOUSE_MODEL ToPOCO(){
			return new Apps.Models.SCV.Sys.WAREHOUSE_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				WAREHOUSE1=this.WAREHOUSE1,
				DESCRIPTION=this.DESCRIPTION,
				ADDRESS1=this.ADDRESS1,
				ADDRESS2=this.ADDRESS2,
				ADDRESS3=this.ADDRESS3,
				CITY=this.CITY,
				STATE=this.STATE,
				COUNTRY=this.COUNTRY,
				POSTAL_CODE=this.POSTAL_CODE,
				ATTENTION_TO=this.ATTENTION_TO,
				PHONE_NUM=this.PHONE_NUM,
				FAX_NUM=this.FAX_NUM,
				EMAIL=this.EMAIL,
				ACTIVE=this.ACTIVE,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
			};
		}
	}
}