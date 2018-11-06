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
        [Key]
        public int Id { get; set; } //商品ID
        [Required]
        public string Name { get; set; } //名前
        [Required]
        public string Hurigana { get; set; } //ふりがな
        [Required]
        public string JAN { get; set; } //JANコード
        [Required]
        public uint PurchasePrice { get; set; } //仕入れ価格
        [Required]
        public uint Price { get; set; } //販売価格
        [Required]
        public uint SafetyStock { get; set; } //安全在庫数
        [Required]
        public DateTime RegistDate { get; set; } //登録日
        [Required]
        public bool IsDeleted { get; set; } //削除フラグ
        public string Note { get; set; } //備考
    }
}
