//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.Sys
{
	public class Virtual_SysModuleModel
	{
			public virtual string Id { get; set; }
			public virtual string Name { get; set; }
			public virtual string EnglishName { get; set; }
			public virtual string ParentId { get; set; }
			public virtual string AreasName { get; set; }
			public virtual string ControllerName { get; set; }
			public virtual string ActionName { get; set; }
			public virtual short FormMethod { get; set; }
			public virtual short OperationType { get; set; }
			public virtual string Iconic { get; set; }
			public virtual Nullable<int> Sort { get; set; }
			public virtual string Remark { get; set; }
			public virtual bool Enable { get; set; }
			public virtual string CreatePerson { get; set; }
			public virtual Nullable<System.DateTime> CreateTime { get; set; }
			public virtual bool IsLast { get; set; }
			public virtual byte[] Version { get; set; }
		}
}
