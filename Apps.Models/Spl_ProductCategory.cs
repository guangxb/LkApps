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
    
    public partial class Spl_ProductCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Spl_ProductCategory()
        {
            this.Spl_Product = new HashSet<Spl_Product>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spl_Product> Spl_Product { get; set; }
    }
}