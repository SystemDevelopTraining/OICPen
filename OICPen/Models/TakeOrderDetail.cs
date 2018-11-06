using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class TakeOrderDetail
    {
        [Key]
        public int Id { get; set; } // 注文明細ID
        [ForeignKey("TakeOrder")]
        public int TakeOrderId { get; set; } // 注文ID
        [ForeignKey("Item")]
        [Required]
        public int Itemid { get; set; }// 商品Id
        [Required]
        public uint Quantity { get; set; } // 数量

        public virtual TakeOrder TakeOrder { get; set; }
        public virtual Item Item { get; set; }
    }
}
