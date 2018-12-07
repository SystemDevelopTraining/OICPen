using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Staffs : Form
    {
        private Services.StaffService Servis ;

        public StaffT Staff
        {
            set
            {
                if (value.Permission != Permission.God
                   && value.Permission != Permission.StaffControl)
                {
                    registerBtn.Enabled = false;
                    fixBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                }
                else
                {
                    registerBtn.Enabled = true;
                    fixBtn.Enabled = true;
                    deleteBtn.Enabled = true;
                }
            }
        }

        public Staffs(Models.OICPenDbContext dbcontext)
        {
            Servis = new Services.StaffService(dbcontext);
            InitializeComponent();
        }

        private void idTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(idTbox,e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var staffs = new string[] { searchNameTbox.Text, idTbox.Text,searchFuriganaTbox.Text };
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
                   Servis.FindByHurigana(searchFuriganaTbox.Text)
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

        private void Staffs_Load(object sender, EventArgs e)
        {
            idTbox.Focus();
            DataShow();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (
                !Utility.TextIsEmpty(registerNameTbox.Text)
                && !Utility.TextIsEmpty(registerNameTbox.Text)
                && !Utility.TextIsEmpty(registerNamePhoneticTbox.Text)
                && !Utility.TextIsEmpty(passwordLbl.Text)
                && !Utility.TextIsEmpty(password2Tbox.Text)
                && passwordTbox != password2Tbox
                && !Utility.TextIsEmpty(permissionCbox.Text)
                )
            {
                if ((errorMessage = Utility.HiraganaCheck(registerNamePhoneticTbox.Text)) == "")
                {
                    Servis.AddStaff(TextToStaff());
                    registerNameTbox.Text = "";
                    registerNamePhoneticTbox.Text = "";
                    passwordTbox.Text = "";
                    password2Tbox.Text ="";
                }
                else
                {
                    MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DataShow();
        }

        private void DataShow()
        {
            staffsDgv.Rows.Clear();
            var dgv = staffsDgv;
            var staffs = Servis.GetAllStaffs();
            foreach (var x in staffs)
            {
                dgv.Rows.Add(x.StaffTID, x.Name, x.Hurigana, x.Permission);
            }
        }

        private StaffT TextToStaff()
        {
            var staff = new StaffT();
            staff.Name = registerNameTbox.Text;
            staff.Hurigana = registerNamePhoneticTbox.Text;
            staff.Password = passwordTbox.Text;
            staff.Permission = (Permission)permissionCbox.SelectedIndex;
                return staff;
        }

        private void staffsDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (staffsDgv.SelectedRows.Count == 0) return;
            var cells = staffsDgv.SelectedRows[0].Cells;
            int id = int.Parse(cells[0].Value.ToString());
            idDispLbl.Text = cells[0].Value.ToString();
            var staff = Servis.FindByID(id);
            registerNameTbox.Text = staff.Name;
            registerNamePhoneticTbox.Text = staff.Hurigana;
            permissionCbox.SelectedIndex = (int)cells[3].Value;
            

            //Dgvの権限を日本語で表示する。
            //Dgvからパスワードを登録・更新テキストボックスに表示する？

        }

        private void fixBtn_Click(object sender, EventArgs e)
        {
            if (idDispLbl.Text == "")
            {
                MessageBox.Show("社畜を選択しないままの更新はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(idDispLbl.Text);
            var staff = TextToStaff();
            
            var staff2=Servis.FindByID(id);
            staff2.Name = staff.Name;
            staff2.Hurigana = staff.Hurigana;
            staff2.Permission = staff.Permission;
            Servis.UpdateStaff(staff2);
            DataShow();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idDispLbl.Text == "")
            {
                MessageBox.Show("社畜を選択しないままの削除はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(idDispLbl.Text);
            Servis.DeleteStaff(id);
            DataShow();
            idDispLbl.Text = "";
            registerNameTbox.Text = "";
            registerNamePhoneticTbox.Text = "";
        }
    }
}
