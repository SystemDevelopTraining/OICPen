using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrderDetailT
    {
        public int GiveOrderDetailTID { get; set; } // 注文明細ID
        public int GiveOrderTID { get; set; } // 注文ID
        public int ItemTID { get; set; } // 商品ID
        public uint Quantity { get; set; } // 数量

        public virtual GiveOrderT GiveOrderT { get; set; }
        public virtual ItemT ItemT { get; set; }
    }
}
