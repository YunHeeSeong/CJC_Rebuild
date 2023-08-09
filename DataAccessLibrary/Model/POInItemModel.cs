using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class POInItemModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string POInItemNo { get; set; }
        public string POInDate { get; set; }
        public int POInGroupCd { get; set; }
        public string POInGroupCdNm { get; set; }

        public int POInUserId { get; set; }

        public string POInUserIdNm { get; set; }

        public string POInCustCd { get; set; }
        public string POInCustCdNm { get; set; }

        public decimal TotQty { get; set; }
        public decimal TotAmt { get; set; }
        public string Remk { get; set; }
        public int Seq { get; set; }
        public string POrderNo { get; set; }
        public int POSeq { get; set; }
        public decimal POrderQty { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public int WhCd { get; set; }
        public decimal Qty { get; set; }
        public decimal BadQty { get; set; }
        public int BadType { get; set; }
        public string BadTypeNm { get; set; }
        public decimal Price { get; set; }
        public decimal Amt { get; set; }
        public string Unit { get; set; }
        public decimal Weight { get; set; }

    }
}
