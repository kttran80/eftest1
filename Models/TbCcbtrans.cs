using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eftest1
{
    [Table("tb_CCBTrans")]
    public partial class TbCcbtrans
    {
        [Key]
        public long TransId { get; set; }
        public long FileId { get; set; }
        public string RefNo { get; set; }
        public string Ccholder { get; set; }
        public string CcholderHash { get; set; }
        public string Msr { get; set; }
        public string Ccinput { get; set; }
        public string Cctype { get; set; }
        public string Cclast4 { get; set; }
        public string FltOrig { get; set; }
        public string OriginAirportName { get; set; }
        public string FltDest { get; set; }
        public string DestinationAirportName { get; set; }
        public string Carrier { get; set; }
        public string FltNum { get; set; }
        public DateTime FltDate { get; set; }
        public bool Ready { get; set; }
        public bool InProcess { get; set; }
        public bool Processed { get; set; }
        public DateTime? ProcessDt { get; set; }
        public string CcauthOrderId { get; set; }
        public string CcauthResult { get; set; }
        public string AuthCode { get; set; }
        public string Success { get; set; }
        public string DocNo { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public string Cctoken { get; set; }
        public int? Dekversion { get; set; }
    }
}
