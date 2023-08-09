using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class CommonCodeModel
    {
        public int CodeId { get; set; }
        public int CodeSeq { get; set; }
        public string CodeNm { get; set; }
        public string Remk { get; set; }
        public string UseYN { get; set; }
        public string CodeSubNm { get; set; }
        public string SubRemk { get; set; }

    }
}
