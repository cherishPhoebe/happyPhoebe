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
    
    public partial class t_h_change_order
    {
        public long id { get; set; }
        public string order_no { get; set; }
        public string check_name { get; set; }
        public Nullable<System.DateTime> check_in_time { get; set; }
        public Nullable<System.DateTime> due_check_out_time { get; set; }
        public Nullable<decimal> price { get; set; }
        public string custom_name { get; set; }
        public Nullable<decimal> room_charge_money { get; set; }
        public Nullable<decimal> consume_money { get; set; }
        public Nullable<decimal> check_money { get; set; }
        public string creater { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string class_no { get; set; }
        public string hotelcode { get; set; }
    }
}
