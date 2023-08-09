using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMINWEB_CJC.Model
{
    public class DisplayDPurchaseOrderModel
    {
        public string POrderNo { get; set; }
        public int Seq { get; set; }
        public string ItemCd { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Amt { get; set; }
        public decimal UnitCd { get; set; }
        public decimal Weight { get; set; }
        public string ReqDelvDate { get; set; }
        public string Remk { get; set; }
    }
}
