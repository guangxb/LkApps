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
	public partial class REPLENISHMENT_REQUEST
	{
		public Apps.Models.SCV.REPLENISHMENT.REPLENISHMENT_REQUEST_MODEL ToPOCO(){
			return new Apps.Models.SCV.REPLENISHMENT.REPLENISHMENT_REQUEST_MODEL(){
								INTERNAL_RPLN_REQ_NUM=this.INTERNAL_RPLN_REQ_NUM,
				COMPANY=this.COMPANY,
				WAREHOUSE=this.WAREHOUSE,
				PRIORITY=this.PRIORITY,
				ITEM=this.ITEM,
				ITEM_DESC=this.ITEM_DESC,
				ALLOCATED_QTY=this.ALLOCATED_QTY,
				QUANTITY_UM=this.QUANTITY_UM,
				ATTRIBUTE_NUM=this.ATTRIBUTE_NUM,
				ALLOCATION_ZONE=this.ALLOCATION_ZONE,
				INTERNAL_WAVE_NUM=this.INTERNAL_WAVE_NUM,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
				CONVERTED_ALLOC_QTY=this.CONVERTED_ALLOC_QTY,
				CONVERTED_QTY_UM=this.CONVERTED_QTY_UM,
				FROM_LOC=this.FROM_LOC,
				TO_LOC=this.TO_LOC,
				FROM_TEMPL_FIELD1=this.FROM_TEMPL_FIELD1,
				FROM_TEMPL_FIELD2=this.FROM_TEMPL_FIELD2,
				FROM_TEMPL_FIELD3=this.FROM_TEMPL_FIELD3,
				FROM_TEMPL_FIELD4=this.FROM_TEMPL_FIELD4,
				FROM_TEMPL_FIELD5=this.FROM_TEMPL_FIELD5,
				TO_TEMPL_FIELD1=this.TO_TEMPL_FIELD1,
				TO_TEMPL_FIELD2=this.TO_TEMPL_FIELD2,
				TO_TEMPL_FIELD3=this.TO_TEMPL_FIELD3,
				TO_TEMPL_FIELD4=this.TO_TEMPL_FIELD4,
				TO_TEMPL_FIELD5=this.TO_TEMPL_FIELD5,
				TASK_CREATED=this.TASK_CREATED,
				FROM_ZONE=this.FROM_ZONE,
				FROM_LPN=this.FROM_LPN,
				FROM_PARENT_LPN=this.FROM_PARENT_LPN,
				TO_ZONE=this.TO_ZONE,
				TO_LPN=this.TO_LPN,
				TO_PARENT_LPN=this.TO_PARENT_LPN,
				REPLENISHMENT_TYPE=this.REPLENISHMENT_TYPE,
				INVENTORY_STS=this.INVENTORY_STS,
			};
		}
	}
}