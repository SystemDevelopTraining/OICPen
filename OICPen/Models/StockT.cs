using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    public class StockT
    {
        [Key]
        public DateTime Date { get; set; } // 年月
        public int ItemTID { get; set; }　// 商品ID
        public uint Quantity { get; set; } // 在庫数

        public virtual ItemT ItemT { get; set; }
    }
}
