using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class OutItemModel
    {
        public string CompCd { get; set; }
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public int PICCd { get; set; }
        public string PICCdNm { get; set; }
        public string PayYNNm { get; set; }
        public string PayDt { get; set; }
        public string EctRequest { get; set; }
        public decimal TotPrice { get; set; }
        public decimal TotVAT { get; set; }
        public string OutItemNo { get; set; }
        public int OutSeq { get; set; }
        public string OutDate { get; set; }
        public int OutUserId { get; set; }
        public string OutUserIdNm { get; set; }
        public string CustomerCd { get; set; }
        public string CustomerNm { get; set; }
        public string OrderNo { get; set; }
        public string OrderDt { get; set; }
        public int OrderSeq { get; set; }
        public decimal Tax { get; set; }
        public string WhCd { get; set; }
        public decimal Qty { get; set; }    //주문수량
        public decimal OutQty { get; set; } //출하수량
        public decimal UPR { get; set; }
        public decimal Price { get; set; }
        public decimal VAT { get; set; }
        public string Unit { get; set; }
        public decimal TotAmt { get; set; }
        public decimal Amt { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public string Remk { get; set; }
    }
}
