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
	public partial class SysLog
	{
		public Apps.Models.Sys.SysLogModel ToPOCO(){
			return new Apps.Models.Sys.SysLogModel(){
								Id=this.Id,
				Operator=this.Operator,
				Message=this.Message,
				Result=this.Result,
				Type=this.Type,
				Module=this.Module,
				CreateTime=this.CreateTime,
			};
		}
	}
}
