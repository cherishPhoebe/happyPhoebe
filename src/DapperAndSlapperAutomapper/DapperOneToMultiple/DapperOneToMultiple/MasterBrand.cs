using System;
using System.Collections.Generic;
using System.Text;

namespace DapperOneToMultiple
{

    /// <summary>
    /// 实体类 MasterBrand, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class MasterBrand
    {        
        public int Id { get; set; }

        public string Name { get; set; }

        public string OtherName { get; set; }

        public string EnglishName { get; set; }

        public string Introduction { get; set; }

        public List<Make> Makes { get; set; }        
    }
}
