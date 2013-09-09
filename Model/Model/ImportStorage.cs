using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{

    /// <summary>
    /// 入库
    /// </summary>
    public class ImportStorage
    {
        public string Id { get; set; }

        public string ManufacturerName { get; set; }

        public string Storage { get; set; }

        /// <summary>
        /// 库位名称
        /// </summary>
        public string LocationName { get; set; }


        public string ProductName { get; set; }

        /// <summary>
        /// Lot.NO
        /// </summary>
        public string LotNum { get; set; }


        public string ProductTime { get; set; }


        public string Number { get; set; }

        public string ArrivalTime { get; set; }


        public bool CheckStatu { get; set; }


        public string MaterialNo { get; set; }

        public string UnitNum { get; set; }


    }
}
