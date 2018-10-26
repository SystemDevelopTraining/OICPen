using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class Stock
    {
        [Key, Column(Order = 2)]
        public DateTime Date { get; set; } // 年月
        [ForeignKey("Items")]
        [Key,Column(Order = 1)]
        public int ItemID { get; set; }　// 商品ID
        public uint Quantity { get; set; } // 在庫数

        public virtual Items Items { get; set; }
    }
}
