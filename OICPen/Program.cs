using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dbContext= new Models.OICPenDbContext();
            var staffServices = new Services.StaffService(dbContext);
            if (staffServices.GetAllStaffs().Count() == 0)
                staffServices.AddStaff(new Models.StaffT {Name="root",Hurigana="るーと",Password="root",Permission=Models.Permission.God });
            Application.Run(new Frame(dbContext));
        }
    }
}
