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
	public partial class LOCATION_INVENTORY_HIS
	{
		public Apps.Models.SCV.LOCATION.LOCATION_INVENTORY_HIS_MODEL ToPOCO(){
			return new Apps.Models.SCV.LOCATION.LOCATION_INVENTORY_HIS_MODEL(){
								INTERNAL_LOCATION_INV=this.INTERNAL_LOCATION_INV,
				WAREHOUSE=this.WAREHOUSE,
				LOCATION=this.LOCATION,
				ITEM=this.ITEM,
				ITEM_DESC=this.ITEM_DESC,
				COMPANY=this.COMPANY,
				PERMANENT=this.PERMANENT,
				ATTRIBUTE_NUM=this.ATTRIBUTE_NUM,
				ON_HAND_QTY=this.ON_HAND_QTY,
				IN_TRANSIT_QTY=this.IN_TRANSIT_QTY,
				ALLOCATED_QTY=this.ALLOCATED_QTY,
				QUANTITY_UM=this.QUANTITY_UM,
				INVENTORY_STS=this.INVENTORY_STS,
				AGING_DATE=this.AGING_DATE,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				LPN=this.LPN,
				PARENT_LPN=this.PARENT_LPN,
				ATTRIBUTE1=this.ATTRIBUTE1,
				ATTRIBUTE2=this.ATTRIBUTE2,
				ATTRIBUTE3=this.ATTRIBUTE3,
				ATTRIBUTE4=this.ATTRIBUTE4,
				ATTRIBUTE5=this.ATTRIBUTE5,
				ATTRIBUTE6=this.ATTRIBUTE6,
				ATTRIBUTE7=this.ATTRIBUTE7,
				ATTRIBUTE8=this.ATTRIBUTE8,
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
