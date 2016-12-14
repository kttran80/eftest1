using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eftest1
{
    [Table("tb_CCBDetails")]
    public partial class TbCcbdetails
    {
        [Key]
        public long DetailId { get; set; }
        public long TransId { get; set; }
        public string TransType { get; set; }
        public string SaleType { get; set; }
        public decimal Amt { get; set; }
        public int Quantity { get; set; }
    }
}
