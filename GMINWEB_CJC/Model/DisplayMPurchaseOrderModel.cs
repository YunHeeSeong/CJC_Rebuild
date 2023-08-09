using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMINWEB_Rebuild.Model
{
    public class DisplayMPurchaseOrderModel
    {
        public string POrderNo { get; set; }        //발주서번호
        public string VatYN { get; set; }           //부가세여부
        public int GroupCd { get; set; }         //발주부서코드
        public int POrderUserId { get; set; }       //발주담당자코드
        public int POrderCustCd { get; set; }       //발주업체코드
        public decimal Amt { get; set; }            //공급가
        public decimal Vat { get; set; }            //부가세
        public string Remk { get; set; }            //비고
    }
}
