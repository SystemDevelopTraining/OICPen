using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class ClientT
    {
        [Key]
        public int Id { get; set; } // 会員ID
        [Required]
        public string Name { get; set; } // 会員名
        [Required]
        public string Hurigana { get; set; } // ふりがな
        [Required]
        public string Address { get; set; } // 住所
        [Required]
        public string PostNum { get; set; } // 郵便番号
        [Required]
        public string PhoneNum { get; set; } // 連絡先

    }
}
