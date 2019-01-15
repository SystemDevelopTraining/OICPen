using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class ClientT
    {
        public int ClientTID { get; set; } // 会員ID
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } // 会員名
        [Required]
        [MaxLength(50)]
        public string Hurigana { get; set; } // ふりがな
        [Required]
        [MaxLength(50)]
        public string Address { get; set; } // 住所
        [Required]
        [MaxLength(8)]
        public string PostNum { get; set; } // 郵便番号
        [Required]
        [MaxLength(14)]
        public string PhoneNum { get; set; } // 連絡先

        public virtual ICollection<TakeOrderT> TakeOrderTs { get; set; }

    }
}
