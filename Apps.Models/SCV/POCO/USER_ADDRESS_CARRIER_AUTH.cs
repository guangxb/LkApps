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
	public partial class USER_ADDRESS_CARRIER_AUTH
	{
		public Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL ToPOCO(){
			return new Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL(){
								USER_ID=this.USER_ID,
				PROVINCE=this.PROVINCE,
				CITY=this.CITY,
				DISCRICT=this.DISCRICT,
				CARRIER=this.CARRIER,
				IsProvided=this.IsProvided,
				IsDelivery=this.IsDelivery,
				NDelivery=this.NDelivery,
				YDelivery=this.YDelivery,
				Crossing=this.Crossing,
			};
		}
	}
}