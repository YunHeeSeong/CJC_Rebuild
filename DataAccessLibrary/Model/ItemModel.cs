using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class ItemModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string FactBizUnit { get; set; }
        public string FactBizUnitNm { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public string MadeYN { get; set; }
        public int MadeType { get; set; }
        public string MadeTypeNm { get; set; }
        public int ItemCls { get; set; }
        public string ItemClsNm { get; set; }
        public int Item1Cls { get; set; }
        public string Item1ClsNm { get; set; }
        public int Item2Cls { get; set; }
        public string Item2ClsNm { get; set; }
        public int Item3Cls { get; set; }
        public string Item3ClsNm { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public string Remk { get; set; }
    }
}
