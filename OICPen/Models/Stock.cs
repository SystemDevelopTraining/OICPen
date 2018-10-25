using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OICPen.Models
{
    class Stock
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
