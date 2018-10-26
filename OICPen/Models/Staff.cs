using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; } // 社員ID
        [Required]
        public string Name { get; set; } // 社員名
        [Required]
        public string Hurigana { get; set; } // ふりがな
        [Required]
        public string Password { get; set; } // パスワード
        [Required]
        public string Permission { get; set; } // 権限
    }
}
