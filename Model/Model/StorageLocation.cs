using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 库位
    /// </summary>
    public class StorageLocation
    {

        public string LocationName { get; set; }

        public string ManufacturerName { get; set; }
        public string ProductName { get; set; }


        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<CheckRecord> CheckRecords { get; set; }

        public virtual ICollection<ExportStorage> Exports { get; set; }

        public virtual ICollection<ImportStorage> Imports { get; set; }



    }
}
