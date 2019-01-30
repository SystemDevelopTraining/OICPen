using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderDetailT
    {
        public int TakeOrderDetailTID { get; set; } // 注文明細ID
        [Required]
        public int TakeOrderTID { get; set; } // 注文ID
        [Required]
        public int ItemTID { get; set; }// 商品Id
        [Required]
        public int Quantity { get; set; } // 数量
        public int TakeOrderPrice { get; set; } //注文時販売価格
        [Required]
        public virtual TakeOrderT TakeOrderT { get; set; }
        public virtual ItemT ItemT { get; set; }
    }
}
