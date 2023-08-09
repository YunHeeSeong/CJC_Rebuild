using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class OrderMonitoringModel
    {
        public string BizUnitNm { get; set; }
        public string FactBizUnitNm { get; set; }
        public string OrderNo { get; set; }
        public int QTY { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public string ShipDt { get; set; }
        public string ProdDueDt { get; set; }
        public decimal OkQty { get; set; }
        public decimal OutQty { get; set; }

    }
}
