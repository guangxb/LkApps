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
	public partial class TRANSFER_ORDER_DETAIL
	{
		public Apps.Models.SCV.TRANSFER.TRANSFER_ORDER_DETAIL_MODEL ToPOCO(){
			return new Apps.Models.SCV.TRANSFER.TRANSFER_ORDER_DETAIL_MODEL(){
								INTERNAL_TRANSFER_LINE_NUM=this.INTERNAL_TRANSFER_LINE_NUM,
				INTERNAL_TRANSFER_NUM=this.INTERNAL_TRANSFER_NUM,
				TRANSFER_ID=this.TRANSFER_ID,
				LINE_NUM=this.LINE_NUM,
				WAREHOUSE=this.WAREHOUSE,
				FROM_LOC=this.FROM_LOC,
				TO_LOC=this.TO_LOC,
				COMPANY=this.COMPANY,
				ITEM=this.ITEM,
				ITEM_DESC=this.ITEM_DESC,
				FROM_LPN=this.FROM_LPN,
				TO_LPN=this.TO_LPN,
				TOTAL_QTY=this.TOTAL_QTY,
				FROM_QTY=this.FROM_QTY,
				TO_QTY=this.TO_QTY,
				QUANTITY_UM=this.QUANTITY_UM,
				BEGIN_DATE_TIME=this.BEGIN_DATE_TIME,
				END_DATE_TIME=this.END_DATE_TIME,
				ATTRIBUTE_NUM=this.ATTRIBUTE_NUM,
				INVENTORY_STS=this.INVENTORY_STS,
				LOCATING_RULE=this.LOCATING_RULE,
				CREATED_USER=this.CREATED_USER,
				CREATED_DATE_TIME=this.CREATED_DATE_TIME,
				LAST_MODIFIED_USER=this.LAST_MODIFIED_USER,
				LAST_MODIFIED_DATE_TIME=this.LAST_MODIFIED_DATE_TIME,
				USER_DEF1=this.USER_DEF1,
				USER_DEF2=this.USER_DEF2,
				USER_DEF3=this.USER_DEF3,
				USER_DEF4=this.USER_DEF4,
				USER_DEF5=this.USER_DEF5,
				USER_DEF6=this.USER_DEF6,
				USER_DEF7=this.USER_DEF7,
				USER_DEF8=this.USER_DEF8,
				CART_ID=this.CART_ID,
				CART_POS=this.CART_POS,
				STATUS=this.STATUS,
				ATTRIBUTE1=this.ATTRIBUTE1,
				ATTRIBUTE2=this.ATTRIBUTE2,
				ATTRIBUTE3=this.ATTRIBUTE3,
				ATTRIBUTE4=this.ATTRIBUTE4,
				ATTRIBUTE5=this.ATTRIBUTE5,
				ATTRIBUTE6=this.ATTRIBUTE6,
				ATTRIBUTE7=this.ATTRIBUTE7,
				ATTRIBUTE8=this.ATTRIBUTE8,
				PARENT_LPN=this.PARENT_LPN,
				REFERENCE_ID=this.REFERENCE_ID,
				REFERENCE_NUM=this.REFERENCE_NUM,
				REFERENCE_NUM_TYPE=this.REFERENCE_NUM_TYPE,
				REFERENCE_LINE_NUM=this.REFERENCE_LINE_NUM,
				PROCESS_STAMP=this.PROCESS_STAMP,
				UPLOAD_INTERFACE_FLAG=this.UPLOAD_INTERFACE_FLAG,
			};
		}
	}
}
