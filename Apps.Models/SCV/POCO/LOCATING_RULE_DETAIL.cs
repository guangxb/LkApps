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
	public partial class LOCATING_RULE_DETAIL
	{
		public Apps.Models.SCV.LOCATING.LOCATING_RULE_DETAIL_MODEL ToPOCO(){
			return new Apps.Models.SCV.LOCATING.LOCATING_RULE_DETAIL_MODEL(){
								LOCATING_RULE=this.LOCATING_RULE,
				QUANTITY_UM=this.QUANTITY_UM,
				SEQUENCE=this.SEQUENCE,
				STRATEGY=this.STRATEGY,
				LOC_SEL_ID=this.LOC_SEL_ID,
				LOC_SEL_NAME=this.LOC_SEL_NAME,
				SPLIT_QTY=this.SPLIT_QTY,
				OBJECT_ID=this.OBJECT_ID,
			};
		}
	}
}