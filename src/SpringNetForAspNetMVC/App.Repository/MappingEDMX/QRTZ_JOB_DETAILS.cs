//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Repository.MappingEDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class QRTZ_JOB_DETAILS
    {
        public QRTZ_JOB_DETAILS()
        {
            this.QRTZ_TRIGGERS = new HashSet<QRTZ_TRIGGERS>();
        }
    
        public string JOB_NAME { get; set; }
        public string JOB_GROUP { get; set; }
        public string DESCRIPTION { get; set; }
        public string JOB_CLASS_NAME { get; set; }
        public Nullable<bool> IS_DURABLE { get; set; }
        public Nullable<bool> REQUESTS_RECOVERY { get; set; }
        public byte[] JOB_DATA { get; set; }
        public Nullable<bool> IS_NONCONCURRENT { get; set; }
        public Nullable<bool> IS_UPDATE_DATA { get; set; }
        public string SCHED_NAME { get; set; }
    
        public virtual ICollection<QRTZ_TRIGGERS> QRTZ_TRIGGERS { get; set; }
    }
}