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
	public partial class DOWNLOAD_RECEIPT_HEADER
	{
		public Apps.Models.SCV.DOWNLOAD.DOWNLOAD_RECEIPT_HEADER_MODEL ToPOCO(){
			return new Apps.Models.SCV.DOWNLOAD.DOWNLOAD_RECEIPT_HEADER_MODEL(){
								INTERFACE_RECORD_ID=this.INTERFACE_RECORD_ID,
				INTERFACE_ACTION_CODE=this.INTERFACE_ACTION_CODE,
				INTERFACE_CONDITION=this.INTERFACE_CONDITION,
				PROCESS_STAMP=this.PROCESS_STAMP,
				WAREHOUSE=this.WAREHOUSE,
				COMPANY=this.COMPANY,
				RECEIPT_ID=this.RECEIPT_ID,
				RECEIPT_TYPE=this.RECEIPT_TYPE,
				PRIORITY=this.PRIORITY,
				LEADING_STS=this.LEADING_STS,
				TRAILING_STS=this.TRAILING_STS,
				ERP_ORDER_ID=this.ERP_ORDER_ID,
				SHIP_FROM=this.SHIP_FROM,
				SHIP_FROM_ADDRESS1=this.SHIP_FROM_ADDRESS1,
				SHIP_FROM_ADDRESS2=this.SHIP_FROM_ADDRESS2,
				SHIP_FROM_CITY=this.SHIP_FROM_CITY,
				SHIP_FROM_STATE=this.SHIP_FROM_STATE,
				SHIP_FROM_COUNTRY=this.SHIP_FROM_COUNTRY,
				SHIP_FROM_POSTAL_CODE=this.SHIP_FROM_POSTAL_CODE,
				SHIP_FROM_NAME=this.SHIP_FROM_NAME,
				SHIP_FROM_ATTENTION_TO=this.SHIP_FROM_ATTENTION_TO,
				SHIP_FROM_EMAIL_ADDRESS=this.SHIP_FROM_EMAIL_ADDRESS,
				SHIP_FROM_PHONE_NUM=this.SHIP_FROM_PHONE_NUM,
				SHIP_FROM_FAX_NUM=this.SHIP_FROM_FAX_NUM,
				SCHEDULED_ARRIVE_DATE=this.SCHEDULED_ARRIVE_DATE,
				ACTUAL_ARRIVE_DATE=this.ACTUAL_ARRIVE_DATE,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				RECV_DOCK=this.RECV_DOCK,
				CLOSE_DATE=this.CLOSE_DATE,
				CREATE_DATE=this.CREATE_DATE,
				START_CHECKIN_DATE=this.START_CHECKIN_DATE,
				END_CHECKIN_DATE=this.END_CHECKIN_DATE,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				TOTAL_QTY=this.TOTAL_QTY,
				TOTAL_LINES=this.TOTAL_LINES,
				UPLOAD_INTERFACE_FLAG=this.UPLOAD_INTERFACE_FLAG,
				CREATE_DATE_TIME=this.CREATE_DATE_TIME,
				CREATE_USER=this.CREATE_USER,
				USER_DEF9=this.USER_DEF9,
				USER_DEF10=this.USER_DEF10,
				UPLOAD_INTERFACE_DATE_TIME=this.UPLOAD_INTERFACE_DATE_TIME,
				UPLOAD_INTERFACE_REQUIRED=this.UPLOAD_INTERFACE_REQUIRED,
				HOST_COMPANY=this.HOST_COMPANY,
				RECEIPT_NOTE=this.RECEIPT_NOTE,
				SHIPPING_NOTE=this.SHIPPING_NOTE,
			};
		}
	}
}
