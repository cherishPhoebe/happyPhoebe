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
    
    public partial class SocoShop_AdminLog
    {
        public int ID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string Action { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<int> AdminID { get; set; }
        public string AdminName { get; set; }
    }
}