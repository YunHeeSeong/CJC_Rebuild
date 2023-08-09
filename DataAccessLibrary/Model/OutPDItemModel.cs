using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class OutPDItemModel
    {
        public string CompCd { get; set; }
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string FactBizUnit { get; set; }
        public string FactBizUnitNm { get; set; }
        public string OrderNo { get; set; }
        public string OrderDt { get; set; }
        public int OutSeq { get; set; }
        public string OutDate { get; set; }
        public int OutGroupCd { get; set; }
        public int OutUserId { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public decimal OutQty { get; set; }     //출하수량
        public decimal StkQty { get; set; }     //재고수량
        public int OrderQty { get; set; }       //주문수량
        public decimal TotQty { get; set; }     //기출하수량
        public decimal RQty { get; set; }       //출하잔여수량
        public string Unit { get; set; }
        public decimal Tax { get; set; }
        public string Remk { get; set; }
        public string EctRequest { get; set; }
    }
}
