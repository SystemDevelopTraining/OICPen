using System.ComponentModel.DataAnnotations;

namespace OICPen.Models
{
    public class StaffT
    {
        public int StaffTID { get; set; } // 社員ID
        public string Name { get; set; } // 社員名
        public string Hurigana { get; set; } // ふりがな
        public string Password { get; set; } // パスワード
        public Permission Permission { get; set; } // 権限
    }

    public enum Permission
    {
        //マスター権限。(特権管理者)
        God = 4,
        //客管理権限。(客管理者)
        ClientControl =3,
        //社員管理権限。(社員管理者)
        StaffControl =2,
        //商品管理権限。(商品管理者)
        ProductControl = 1,
        //仕入れ管理権限。(入庫管理者)
        PurchasingControl = 0
    }

}
