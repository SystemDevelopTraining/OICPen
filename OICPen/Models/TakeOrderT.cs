using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderT
    {
        public int TakeOrderTID { get; set; } //注文ID
        public DateTime TakeOrdDate { get; set; } // 注文日
        public DateTime? ShipDate { get; set; } // 出庫日
        public int ClientTID { get; set; } // 会員ID

        
        public virtual ClientT ClientT { get; set; }
    }
}
