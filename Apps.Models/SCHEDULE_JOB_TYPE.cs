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
    
    public partial class SCHEDULE_JOB_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEDULE_JOB_TYPE()
        {
            this.SCHEDULE_JOB = new HashSet<SCHEDULE_JOB>();
        }
    
        public string JOB_TYPE { get; set; }
        public string JOB_CLASS { get; set; }
        public string DESCRIPTION { get; set; }
        public string ASSEMBLY { get; set; }
        public string NAMESPACE { get; set; }
        public string CLASS { get; set; }
        public string METHOD { get; set; }
        public string PARA1_NAME { get; set; }
        public string PARA2_NAME { get; set; }
        public string PARA3_NAME { get; set; }
        public string PARA4_NAME { get; set; }
        public string PARA5_NAME { get; set; }
        public string PARA6_NAME { get; set; }
        public string PARA7_NAME { get; set; }
        public string PARA8_NAME { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string SYSTEM_CREATED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEDULE_JOB> SCHEDULE_JOB { get; set; }
    }
}
