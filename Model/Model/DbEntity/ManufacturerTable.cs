using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 厂家表
    /// </summary>
    public class ManufacturerTable
    {

        public string ManufacturerName { get; set; }
        public string Memo { get; set; }
        public virtual ICollection<ProductTable> Products { get; set; }
        public virtual ICollection<ImportStorageTable> Imports { get; set; }
    }
}
