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
    using System;
    using System.Collections.Generic;
    
    public partial class SysStruct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysStruct()
        {
            this.SysPosition = new HashSet<SysPosition>();
            this.SysStruct1 = new HashSet<SysStruct>();
            this.SysUser = new HashSet<SysUser>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public int Sort { get; set; }
        public string Higher { get; set; }
        public bool Enable { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysPosition> SysPosition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysStruct> SysStruct1 { get; set; }
        public virtual SysStruct SysStruct2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysUser> SysUser { get; set; }
    }
}
