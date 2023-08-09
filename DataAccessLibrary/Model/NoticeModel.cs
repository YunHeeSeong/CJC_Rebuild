using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class NoticeModel
    {
        public string CompCd { get; set; }
        public int NoticeCd { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ReadRoleId { get; set; }
        public string Remk { get; set; }
        public int RegUserId { get; set; }
        public DateTime RegDate { get; set; }
        public int UptUserId { get; set; }
        public DateTime UptDate { get; set; }

    }
}
