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
    
    public partial class t_w_sale
    {
        public long id { get; set; }
        public string goods_code { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> cost { get; set; }
        public Nullable<System.DateTime> sale_time { get; set; }
        public string hotel_code { get; set; }
        public string warehouse_code { get; set; }
        public string seller { get; set; }
        public string remark { get; set; }
    }
}
