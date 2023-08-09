using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class InventoryModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string MadeType { get; set; }
        public string FactBizUnit { get; set; }
        public string FactBizUnitNm { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public string ItemClsNm { get; set; }
        public string Item1ClsNm { get; set; }
        public string Item2ClsNm { get; set; }
        public string Item3ClsNm { get; set; }
        public decimal QTY { get; set; }
        public string Unit { get; set; }

    }
}
