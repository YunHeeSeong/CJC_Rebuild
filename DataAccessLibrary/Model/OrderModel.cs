using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class OrderModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string OrderNo { get; set; }
        public string OrderDt { get; set; }
        public int OrderCls { get; set; }
        public string OrderClsNm { get; set; }
        public string CustomerCd { get; set; }
        public string CustomerNm { get; set; }
        public string PhoneNo { get; set; }
        public int PICCd { get; set; }
        public string PICCdNm { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public int MadeType { get; set; }
        public string MadeTypeNm { get; set; }
        public int Qty { get; set; }
        public string PayYN { get; set; }
        public string PayYNNm { get; set; }
        public string PayDt { get; set; }
        public string FactBizUnit { get; set; }
        public string FactBizUnitNm { get; set; }
        public string EctRequest { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public string Unit { get; set; }
        public int WorkState { get; set; }
        public string WorkStateNm { get; set; }
        public string Remk { get; set; }
    }
}
