using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class StockT
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        [MaxLength(6), MinLength(6)]
        public string Date { get; set; } // 年月
        [Key]
        [Column(Order = 2)]
        [Required]
        public int ItemTID { get; set; }　// 商品ID
        public uint Quantity { get; set; } // 在庫数

        public virtual ItemT ItemT { get; set; }
    }
}
