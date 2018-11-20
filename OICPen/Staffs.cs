using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Staffs : Form
    {
        private Services.StaffService Servis = new Services.StaffService(new Models.OICPenDbContext());

        public Staffs()
        {
            InitializeComponent();
        }

        private void idTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(idTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var staffs = new string[] { searchNameTbox.Text, idTbox.Text,searchHuriganaTbox.Text };
            var processes = new Func<List<Models.StaffT>>[]
            {

                 //名前での検索
                () =>
                    Servis.FindByName(searchNameTbox.Text),
                
                //IDでの検索
                () =>
                    new List<Models.StaffT>(
                        new Models.StaffT[] { Servis.FindByID(int.Parse(idTbox.Text)) }
                    ),

                () =>
                   Servis.FindByHurigana(searchHuriganaTbox.Text)
            };


            uint itemCount = 0;
            uint currentIndex = 0;
            for (uint i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != "")
                {
                    itemCount++;
                    currentIndex = i;
                }
            }

            if (itemCount != 1)
            {
                MessageBox.Show("検索項目が一つではありません", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    staffsDgv.Rows.Clear();
                    (processes[currentIndex]()).ForEach(stf =>
                    {
                        staffsDgv.Rows.Add(
                            stf.StaffTID,
                            stf.Name,
                            stf.Hurigana,
                            stf.Permission
                            );
                    });
                }
                catch
                {

                }
            }

        }
    }
}
