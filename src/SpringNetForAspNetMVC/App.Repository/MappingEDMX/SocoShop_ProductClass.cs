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
    
    public partial class SocoShop_ProductClass
    {
        public int ID { get; set; }
        public Nullable<int> FatherID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string ClassName { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public Nullable<long> TaobaoID { get; set; }
        public Nullable<int> ShopClassID { get; set; }
        public int UserId { get; set; }
        public string ClassImg { get; set; }
    }
}
