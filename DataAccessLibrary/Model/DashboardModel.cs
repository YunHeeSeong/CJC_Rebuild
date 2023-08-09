using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class DashboardModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public decimal SumPOInQty { get; set; }
        public int SumOrderQTY { get; set; }
        public decimal SumOkQTY { get; set; }
        public decimal SumOutQty { get; set; }
        public decimal TotQty { get; set; }
        public int TotalQty { get; set; }
        public int month { get; set; }
        public decimal ClameRate { get; set; }
        public int month2 { get; set; }
        public int leadtime { get; set; }
    }
}
