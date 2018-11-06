using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class GiveOrderDetail
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
        public virtual GiveOrder GiveOrder { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
