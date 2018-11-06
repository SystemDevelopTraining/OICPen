using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class StaffT
    {
        public int StaffTID { get; set; } // 社員ID
        public string Name { get; set; } // 社員名
        public string Hurigana { get; set; } // ふりがな
        public string Password { get; set; } // パスワード
        public string Permission { get; set; } // 権限
    }
}
