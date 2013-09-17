using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 产品表
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 检验状态
        /// </summary>
        public bool CheckStatu { get; set; }

        /// <summary>
        /// 厂家
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 品名
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// lot号
        /// </summary>
        public string LotNum { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductTime { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 检验时间
        /// </summary>
        public string CheckTime { get; set; }

        /// <summary>
        /// 料号
        /// </summary>
        public string MaterialNo { get; set; }

        /// <summary>
        /// 单位数量
        /// </summary>
        public string UnitNum { get; set; }




    }
}
