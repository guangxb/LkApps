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
	public partial class WAVE_MASTER
	{
		public Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL ToPOCO(){
			return new Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				MASTER_NAME=this.MASTER_NAME,
				PRIORITY=this.PRIORITY,
				SHIPMENT_FILTER=this.SHIPMENT_FILTER,
				WAVE_MODE=this.WAVE_MODE,
				AUTO_RUN=this.AUTO_RUN,
				AUTO_RELEASE=this.AUTO_RELEASE,
				WAVE_FLOW=this.WAVE_FLOW,
				CREATE_TASK=this.CREATE_TASK,
				SHORT_MODE=this.SHORT_MODE,
				MAX_SHIPMENTS=this.MAX_SHIPMENTS,
				MAX_LINES=this.MAX_LINES,
				MAX_ITEMS=this.MAX_ITEMS,
				MAX_QTY=this.MAX_QTY,
				MAX_WEIGHT=this.MAX_WEIGHT,
				MAX_VOLUME=this.MAX_VOLUME,
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
				ACTIVE=this.ACTIVE,
				CONTAINER_CREATION_CRITERIA=this.CONTAINER_CREATION_CRITERIA,
			};
		}
	}
}