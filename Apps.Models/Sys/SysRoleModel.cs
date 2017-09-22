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
using System.ComponentModel.DataAnnotations;

namespace Apps.Models.Sys
{
    public partial class SysRoleModel : Virtual_SysRoleModel
    {
        public override string Id { get; set; }
    
        [Display(Name = "角色名称"),Required]
        public override string Name { get; set; }

        [Display(Name = "说明"), Required]
        public override string Description { get; set; }
        [Display(Name = "创建时间")]
        public override DateTime CreateTime { get; set; }
        [Display(Name = "创建人")]
        public override string CreatePerson { get; set; }
        [Display(Name = "拥有的用户")]
        public string UserName { get; set; }//拥有的用户

        public string Flag { get; set; }//用户分配角色
    }
    /// <summary>
    /// 根据角色分配用户展示页Model
    /// </summary>
    public partial class SysUserByRoleModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public string TrueName { get; set; }
        public string Flag { get; set; }

    }

    /// <summary>
    /// 根据角色分配用户模型
    /// </summary>

    public partial class AssignUserModel{
        public string UserId { get; set; }

        public bool @Checked { get; set; }
    }

    public partial class RoleEditModel
    {
        [Required]
        string Id { get; set; }
        [Display(Name = "角色名称"), Required]
        public string Name { get; set; }
        [Display(Name = "说明"), Required]
        public bool Description { get; set; }
    }
}
