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
    
    public partial class t_u_protocol_price
    {
        public long id { get; set; }
        public string archives_no { get; set; }
        public Nullable<decimal> price { get; set; }
        public string room_type_code { get; set; }
        public string hotel_code { get; set; }
        public string remark { get; set; }
        public Nullable<decimal> first_deposit { get; set; }
        public Nullable<decimal> start_price { get; set; }
        public Nullable<decimal> add_unit_time_price { get; set; }
        public Nullable<decimal> add_top_money { get; set; }
        public Nullable<System.DateTime> last_mod_time { get; set; }
    }
}