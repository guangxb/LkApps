//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
	public partial class QiMen_RequestLog
	{
		public Apps.Models.QiMen.QiMen_RequestLogModel ToPOCO(){
			return new Apps.Models.QiMen.QiMen_RequestLogModel(){
								Id=this.Id,
				RequestBody=this.RequestBody,
				Interface=this.Interface,
				Url=this.Url,
				Ip=this.Ip,
				CustomerId=this.CustomerId,
			};
		}
	}
}