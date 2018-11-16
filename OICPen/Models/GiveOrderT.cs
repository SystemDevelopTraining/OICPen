using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrderT
    {
        public int GiveOrderTID { get; set; } // 発注ID
        [Required]
        public DateTime GiveOrdDate { get; set; } //発注日
        public DateTime? CompleteDate { get; set; } //入庫日
        [Required]
        public int StaffTID { get; set; } // 社員ID

        public virtual StaffT StaffT { get; set; }

        public virtual ICollection<GiveOrderDetailT> GiveOrderDetailTs { get; set; }
    }
}
