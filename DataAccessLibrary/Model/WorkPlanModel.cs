using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class WorkPlanModel
    {
        public string BizUnit { get; set; }
        public string BizUnitNm { get; set; }
        public string FactBizUnit { get; set; }
        public string FactBizUnitNm { get; set; }
        public string WorkPlanNo { get; set; }
        public string WorkOrderNo { get; set; }
        public string WorkPlanDt { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public decimal Qty { get; set; }
        public string EctRequest { get; set; }
        public int AppUserId { get; set; }
        public string AppUserIdNm { get; set; }
        public string AppDt { get; set; }
        public string AppYN { get; set; }
        public string AppYNNm { get; set; }
        public int WorkState { get; set; }
        public string WorkStateNm { get; set; }
        public string Remk { get; set; }
    }
}
