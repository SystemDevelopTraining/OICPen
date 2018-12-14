using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderT
    {
        public int TakeOrderTID { get; set; } //注文ID
        [Required]
        public DateTime TakeOrderDate { get; set; } // 注文日
        public DateTime? ShipDate { get; set; } // 出庫日
        [Required]
        public int ClientTID { get; set; } // 会員ID
        [Required]
        public int StaffTID { get; set; } //社員ID
        
        public virtual ClientT ClientT { get; set; }
        public virtual ICollection<TakeOrderDetailT> TakeOrderDetailTs { get; set; }
        public virtual StaffT StaffT { get; set; }
    }
}
