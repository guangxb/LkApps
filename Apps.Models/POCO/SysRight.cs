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
	public partial class SysRight
	{
		public Apps.Models.Sys.SysRightModel ToPOCO(){
			return new Apps.Models.Sys.SysRightModel(){
								Id=this.Id,
				ModuleId=this.ModuleId,
				RoleId=this.RoleId,
				Rightflag=this.Rightflag,
			};
		}
	}
}
