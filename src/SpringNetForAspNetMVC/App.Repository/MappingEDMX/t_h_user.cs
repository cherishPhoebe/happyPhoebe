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
    
    public partial class t_h_user
    {
        public long id { get; set; }
        public string link_code { get; set; }
        public string hotel_code { get; set; }
        public string dept_code { get; set; }
        public string user_id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public Nullable<short> sex { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public short forbidden { get; set; }
        public string position_id { get; set; }
        public string fingerprint { get; set; }
        public string mobile { get; set; }
        public string empl_no { get; set; }
        public string qq { get; set; }
        public string weixin { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string remark { get; set; }
        public Nullable<short> salesman { get; set; }
        public Nullable<short> islink { get; set; }
        public Nullable<short> allow_manual_price { get; set; }
        public Nullable<decimal> discount_lower_limit { get; set; }
    }
}