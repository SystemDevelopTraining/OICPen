using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    class StaffService
    {
        private OICPenDbContext context;
        public StaffService(OICPenDbContext context)
        {
            this.context = context;
        }


        /*---------------------------------------------------------------
        [役割] すべての社畜情報をItem型のListにして返す
        [引数] なし
        [返り値] すべての社畜情報
        ---------------------------------------------------------------*/
        public List<StaffT> GetAllStaffs()
        {
            var staffs = from i in context.Staffs
                        orderby i.StaffTID
                         select i;

            return staffs.ToList();
        }

        /*---------------------------------------------------------------
         [役割] 社畜を追加する
         [引数] i: 追加したい社畜情報
         [返り値] 追加した社畜情報
         ---------------------------------------------------------------*/
        public StaffT AddStaff(StaffT i)
        {
            var staff = context.Staffs.Add(i);
            context.SaveChanges();

            return staff;
        }
        /*---------------------------------------------------------------
       [役割] 社畜情報の更新
       [引数] i: 更新したい社畜情報
       [返り値] 更新した社畜情報
       ---------------------------------------------------------------*/
        public StaffT UpdateStaff(StaffT i)
        {
            var staff = context.Staffs.Single(x => x.StaffTID == i.StaffTID);
            staff.Name = i.Name;
            staff.Hurigana = i.Hurigana;
            staff.Password = i.Password;
            staff.Permission = i.Permission;
            context.SaveChanges();

            return staff;

        }
        /*---------------------------------------------------------------
        [役割] 社畜を削除する
        [引数] i: 削除する社畜ID
        [返り値] 削除した社畜情報
        ---------------------------------------------------------------*/
        public StaffT DeleteStaff(int id)
        {
            var staff = context.Staffs.Single(x => x.StaffTID == id);
            context.Staffs.Remove(staff);
            context.SaveChanges();
            return staff;
        }
        /*---------------------------------------------------------------
         [役割] 名前で社畜を検索
         [引数] i: 社畜名
         [返り値] 一致する社畜情報一覧
         ---------------------------------------------------------------*/
        public List<StaffT> FindByName(string name)
        {
            var staffs = context.Staffs.Where(x => x.Name.Contains(name) );
            return staffs.ToList();
        }
        /*---------------------------------------------------------------
         [役割] IDで社畜を検索
         [引数] i: 更新したい社畜情報
         [返り値] 更新した社畜情報
         ---------------------------------------------------------------*/
        public StaffT FindByID(int id)
        {
            var staff = context.Staffs.Single(x => x.StaffTID == id );
            return staff;
        }

        /*---------------------------------------------------------------
        [役割] ふりがなから社畜情報を検索
        [引数] id: 社畜情報のID
        [返り値] ふりがなと一致する社畜情報
        ---------------------------------------------------------------*/
        public List<StaffT> FindByHurigana(string hurigana)
        {
            var staffs = context.Staffs.Where(x => x.Hurigana.Contains(hurigana));
            return staffs.ToList();
        }
    }
}
