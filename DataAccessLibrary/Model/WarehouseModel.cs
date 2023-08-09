using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Model
{
    public class WarehouseModel
    {
        //고객관리
        public string BizUnit { get; set; }     //사업장번호
        public string WhCd { get; set; }        //관리번호
        public string WhNm { get; set; }        //취급점
        public string WhType { get; set; }      //성명
        public string WhLoc { get; set; }       //생년월일
        public int RegUserId { get; set; }      //성별
        public DateTime RegDate { get; set; }   //이동전화
        public int UptUserId { get; set; }      //자택주소
        public DateTime UptDate { get; set; }   //직장주소
        public string REMK1 { get; set; }      //직업
        public string REMK2 { get; set; }       //취미
        public string REMK3 { get; set; }      //방문동기
        public string REMK4 { get; set; }      //탈모유형
        public string REMK5 { get; set; }       //가발착용경험

    }
}
