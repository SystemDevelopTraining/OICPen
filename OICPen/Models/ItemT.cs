using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class ItemT
    {
        public int ItemTID { get; set; } //商品ID
        public string Name { get; set; } //名前
        public string Hurigana { get; set; } //ふりがな
        public string JAN { get; set; } //JANコード
        public uint PurchasePrice { get; set; } //仕入れ価格
        public uint Price { get; set; } //販売価格
        public uint SafetyStock { get; set; } //安全在庫数
        public DateTime RegistDate { get; set; } //登録日
        public bool IsDeleted { get; set; } //削除フラグ
        public string Note { get; set; } //備考
    }
}
