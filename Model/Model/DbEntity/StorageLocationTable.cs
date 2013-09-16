using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 库位表
    /// </summary>
    public class StorageLocationTable
    {

        /// <summary>
        /// 库位名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 厂家名称
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }


        public virtual ICollection<ProductTable> Products { get; set; }

        public virtual ICollection<CheckRecordTable> CheckRecords { get; set; }

        public virtual ICollection<ExportStorageTable> Exports { get; set; }

        public virtual ICollection<ImportStorageTable> Imports { get; set; }



    }
}
