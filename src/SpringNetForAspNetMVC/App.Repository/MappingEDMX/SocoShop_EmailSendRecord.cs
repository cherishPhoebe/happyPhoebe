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
    
    public partial class SocoShop_EmailSendRecord
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<int> IsSystem { get; set; }
        public string EmailList { get; set; }
        public string OpenEmailList { get; set; }
        public Nullable<int> IsStatisticsOpendEmail { get; set; }
        public Nullable<int> SendStatus { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
    }
}
