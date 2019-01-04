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
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } //名前
        [Required]
        [MaxLength(50)]
        public string Hurigana { get; set; } //ふりがな
        [Required]
        [MaxLength(13)]
        public string JAN { get; set; } //JANコード
        [Required]
        public int PurchasePrice { get; set; } //仕入れ価格
        [Required]
        public int Price { get; set; } //販売価格
        [Required]
        public int SafetyStock { get; set; } //安全在庫数
        [Required]
        public DateTime RegistDate { get; set; } //登録日
        [Required]
        public bool IsDeleted { get; set; } //削除フラグ
        [MaxLength(30)]
        public string Note { get; set; } //備考
        public virtual ICollection<TakeOrderDetailT> TakeOrderDetailTs { get; set; }
        public virtual ICollection<GiveOrderDetailT> GiveOrderDetailTs { get; set; }

    }
}
