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
	public partial class PACKING_CLASS
	{
		public Apps.Models.SCV.PACKING.PACKING_CLASS_MODEL ToPOCO(){
			return new Apps.Models.SCV.PACKING.PACKING_CLASS_MODEL(){
								INTERNAL_NUM=this.INTERNAL_NUM,
				PACKING_CLASS1=this.PACKING_CLASS1,
				DESCRIPTION=this.DESCRIPTION,
				CONTAINER_GROUP=this.CONTAINER_GROUP,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
			};
		}
	}
}
