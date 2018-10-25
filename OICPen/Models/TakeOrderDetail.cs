using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    class TakeOrderDetail
    {
        [Key]
        public int Id { get; set; } // 注文明細ID
        [ForeignKey("TakeOrder")]
        [Required]
        public int TakeOrderId { get; set; } // 注文ID
        [Required]
        public uint Quantity { get; set; } // 数量

        public virtual TakeOrder TakeOrder { get; set; }
    }
}
