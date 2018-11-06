using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class ClientT
    {
        public int ClientTID { get; set; } // 会員ID
        public string Name { get; set; } // 会員名
        public string Hurigana { get; set; } // ふりがな
        public string Address { get; set; } // 住所
        public string PostNum { get; set; } // 郵便番号
        public string PhoneNum { get; set; } // 連絡先

    }
}
