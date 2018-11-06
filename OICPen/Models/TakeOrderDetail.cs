using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderDetail
    {
        [Key]
        public int Id { get; set; } // 注文明細ID
        public int TakeOrderId { get; set; } // 注文ID
        
        [Required]
        public int ItemId { get; set; }// 商品Id
        [Required]
        public uint Quantity { get; set; } // 数量

        [ForeignKey("TakeOrder")]
        public virtual TakeOrder TakeOrder { get; set; }
        [ForeignKey("Item")]
        public virtual Item Item { get; set; }
    }
}
