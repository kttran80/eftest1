using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eftest1
{
    [Table("tb_CCBFiles")]
    public partial class TbCcbfiles
    {
        [Key]
        public long FileId { get; set; }
        public string FileName { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime RetrieveDt { get; set; }
        public string Copied { get; set; }
        public string BatchNo { get; set; }
        public string TerminalId { get; set; }
        public string UserId { get; set; }
        public string DeviceId { get; set; }
        public string SledId { get; set; }
        public string Format { get; set; }
        public int? TransCount { get; set; }
        public decimal? TotalAmt { get; set; }
        public string Status { get; set; }
        public int? FooterTransCount { get; set; }
        public decimal? FooterTotalAmt { get; set; }
        public string ErrorMessage { get; set; }
        public string PayloadRequest { get; set; }
    }
}
