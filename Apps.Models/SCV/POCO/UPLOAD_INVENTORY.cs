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
	public partial class UPLOAD_INVENTORY
	{
		public Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL ToPOCO(){
			return new Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL(){
								INTERFACE_RECORD_ID=this.INTERFACE_RECORD_ID,
				INTERFACE_ACTION_CODE=this.INTERFACE_ACTION_CODE,
				INTERFACE_CONDITION=this.INTERFACE_CONDITION,
				PROCESS_STAMP=this.PROCESS_STAMP,
				WAREHOUSE=this.WAREHOUSE,
				ITEM=this.ITEM,
				COMPANY=this.COMPANY,
				QUANTITY=this.QUANTITY,
				INVENTORY_STS=this.INVENTORY_STS,
				LOT=this.LOT,
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
