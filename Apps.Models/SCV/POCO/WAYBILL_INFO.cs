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
	public partial class WAYBILL_INFO
	{
		public Apps.Models.SCV.WAYBILL.WAYBILL_INFO_MODEL ToPOCO(){
			return new Apps.Models.SCV.WAYBILL.WAYBILL_INFO_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				TRACKING_NUMBER=this.TRACKING_NUMBER,
				CARRIER=this.CARRIER,
				SHORT_ADDRESS=this.SHORT_ADDRESS,
				SHIPPING_BRANCH_CODE=this.SHIPPING_BRANCH_CODE,
				SHIPPING_BRANCH_NAME=this.SHIPPING_BRANCH_NAME,
				CONSIGNEE_BRANCH_CODE=this.CONSIGNEE_BRANCH_CODE,
				CONSIGNEE_BRANCH_NAME=this.CONSIGNEE_BRANCH_NAME,
				INTERNAL_SHIPMENT_NUM=this.INTERNAL_SHIPMENT_NUM,
				INTERNAL_CONTAINER_NUM=this.INTERNAL_CONTAINER_NUM,
				NOTICE_CODE=this.NOTICE_CODE,
				PRINT_QUANTITY=this.PRINT_QUANTITY,
				NOTICE_MESSAGE=this.NOTICE_MESSAGE,
				STATUS=this.STATUS,
				REAL_USER_ID=this.REAL_USER_ID,
				VOLUME=this.VOLUME,
				WEIGHT=this.WEIGHT,
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
				CREATE_TIME=this.CREATE_TIME,
				PICKUP_TIME=this.PICKUP_TIME,
				SIGN_TIME=this.SIGN_TIME,
			};
		}
	}
}