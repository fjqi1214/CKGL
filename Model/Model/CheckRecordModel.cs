﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 盘点类
    /// </summary>
    public class CheckRecordModel
    {
        public string Id { get; set; }
        public string LocationName { get; set; }

        public string ProductName { get; set; }

        public bool CheckStatus { get; set; }

        public string LotNum { get; set; }

        public string UnitNumber { get; set; }
    }
}