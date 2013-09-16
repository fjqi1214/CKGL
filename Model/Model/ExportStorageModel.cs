using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 出库类
    /// </summary>
    public class ExportStorageModel
    {
        public string Id { get; set; }

        public string LocationName { get; set; }

        public string ProductName { get; set; }

        public string LotNumber { get; set; }

        public string ExpNum { get; set; }

        public string ExpTime { get; set; }

        public string UnitNum { get; set; }
    }
}
