using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrderDetailT
    {
        [Key]
        public int Id { get; set; } // 注文明細ID
        [Required]
        public int GiveOrderId { get; set; } // 注文ID
        [Required]
        public int Itemid { get; set; } // 商品ID
        [Required]
        public uint Quantity { get; set; } // 数量

        [ForeignKey("GiveOrderId")]
        public virtual GiveOrderT GiveOrder { get; set; }
        [ForeignKey("ItemId")]
        public virtual ItemT Item { get; set; }
    }
}
