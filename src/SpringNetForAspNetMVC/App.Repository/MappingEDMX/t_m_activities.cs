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
    
    public partial class t_m_activities
    {
        public long id { get; set; }
        public string activities_name { get; set; }
        public string hotel_code { get; set; }
        public Nullable<long> card_typeid { get; set; }
        public string room_code { get; set; }
        public Nullable<System.DateTime> begin_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<short> activity_type { get; set; }
        public Nullable<System.DateTime> last_modtime { get; set; }
        public string @operator { get; set; }
        public string remark { get; set; }
    }
}