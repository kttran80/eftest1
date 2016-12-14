using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eftest1
{
    [Table("tb_CCBSaleTypes")]
    public partial class TbCcbsaleTypes
    {
        [Key]       
        public string ProductCode { get; set; }
        public string Eddreason { get; set; }
        public string Description { get; set; }
    }
}
