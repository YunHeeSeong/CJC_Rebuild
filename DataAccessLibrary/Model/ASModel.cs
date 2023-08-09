using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class ASModel
    {
        public string BizUnit { get; set; }
        public string FactBizUnit { get; set; }
        public string AsNo { get; set; }
        public string OrderNo { get; set; }
        public string CustomerCd { get; set; }
        public string CustomerNm { get; set; }
        public string CustomerPhone { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public int AsType { get; set; }
        public string AsTypeNm { get; set; }
        public DateTime AsRecvDt  { get; set; }
        public DateTime AsCompDt { get; set; }
        public int AsUserId { get; set; }
        public string AsUserIdNm { get; set; }
        public int AsManagerId { get; set; }
        public string AsManageIdNm { get; set; }
        public int ProcStatus { get; set; }
        public string ProcStatusNm { get; set; }
        public string ReqDetail { get; set; }
        public string ImproveDetail { get; set; }
        public string Remk { get; set; }
    }
}
