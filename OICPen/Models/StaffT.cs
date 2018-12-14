using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class StaffT
    {
        public int StaffTID { get; set; } // 社員ID
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } // 社員名
        [Required]
        [MaxLength(50)]
        public string Hurigana { get; set; } // ふりがな
        [Required]
        [MaxLength(20)]
        public string Password { get; set; } // パスワード
        [Required]
        public Permission Permission { get; set; } // 権限
    }

    public enum Permission
    {
        //マスター権限。(特権管理者)
        God = 0,
        //客管理権限。(客管理者)
        ClientControl =1,
        //社員管理権限。(社員管理者)
        StaffControl =2,
        //商品管理権限。(商品管理者)
        ProductControl = 3,
        //仕入れ管理権限。(入庫管理者)
        PurchasingControl = 4
    }

}
