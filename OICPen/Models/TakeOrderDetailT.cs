using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderDetailT
    {
        public int TakeOrderDetailTID { get; set; } // 注文明細ID
        public int TakeOrderTID { get; set; } // 注文ID
        public int ItemTID { get; set; }// 商品Id
        public uint Quantity { get; set; } // 数量

        public virtual TakeOrderT TakeOrderT { get; set; }
        public virtual ItemT ItemT { get; set; }
    }
}
