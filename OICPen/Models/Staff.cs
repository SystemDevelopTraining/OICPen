using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Models
{
    class Staff
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
