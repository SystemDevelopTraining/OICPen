using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrderDetailT
    {
        public int GiveOrderDetailTID { get; set; } // 発注明細ID
        [Required]
        public int GiveOrderTID { get; set; } // 発注ID
        [Required]
        public int ItemTID { get; set; } // 商品ID
        [Required]
        public int Quantity { get; set; } // 数量
        public int GiveOrderPurchasePrice { get; set; } //注文時仕入れ価格
        [Required]
        public virtual GiveOrderT GiveOrderT { get; set; }
        public virtual ItemT ItemT { get; set; }
    }
}
