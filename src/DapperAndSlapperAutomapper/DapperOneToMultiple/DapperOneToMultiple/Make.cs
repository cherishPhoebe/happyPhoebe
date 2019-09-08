using System;
using System.Collections.Generic;
using System.Text;

namespace DapperOneToMultiple
{
    /// <summary>
    /// 实体类 Make, 此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    [Serializable]
    public partial class Make
    {
        public int Id { get; set; }

        public int? MasterBrandId { get; set; }

        public string Name { get; set; }

        public string Other_Name { get; set; }

        public string Phone { get; set; }

        public string Web_Site { get; set; }

        public string Introduction { get; set; }
    }
}
