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
    
    public partial class t_h_history_order_price
    {
        public long id { get; set; }
        public string hisitory_order_no { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<short> is_use { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string hotel_code { get; set; }
        public Nullable<short> check_in_type { get; set; }
        public Nullable<System.DateTime> last_mod_time { get; set; }
        public string last_mod_person { get; set; }
        public Nullable<short> is_hand_price { get; set; }
        public Nullable<short> is_reserve_price { get; set; }
    }
}