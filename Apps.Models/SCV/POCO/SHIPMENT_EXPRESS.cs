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
	public partial class SHIPMENT_EXPRESS
	{
		public Apps.Models.SCV.SHIPMENT.SHIPMENT_EXPRESS_MODEL ToPOCO(){
			return new Apps.Models.SCV.SHIPMENT.SHIPMENT_EXPRESS_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				INTERNAL_SHIPMENT_NUM=this.INTERNAL_SHIPMENT_NUM,
				SHIPMENT_ID=this.SHIPMENT_ID,
				WAREHOUSE=this.WAREHOUSE,
				COMPANY=this.COMPANY,
				INTERNAL_WAVE_NUM=this.INTERNAL_WAVE_NUM,
				INTERNAL_LOAD_NUM=this.INTERNAL_LOAD_NUM,
				CARRIER=this.CARRIER,
				EXPRESS_ID=this.EXPRESS_ID,
				STATUS=this.STATUS,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				USER_STAMP=this.USER_STAMP,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				CONTAINER_ID=this.CONTAINER_ID,
				INTERNAL_CONTAINER_NUM=this.INTERNAL_CONTAINER_NUM,
				TOTAL_WEIGHT=this.TOTAL_WEIGHT,
			};
		}
	}
}