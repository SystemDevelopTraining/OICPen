using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    class Client
    {
        [Key]
        public int Id { get; set; } // 会員ID
        [Required]
        public string Name { get; set; } // 会員名
        [Required]
        public string Address { get; set; } // 住所
        [Required]
        public string PhoneNum { get; set; } // 連絡先

    }
}
