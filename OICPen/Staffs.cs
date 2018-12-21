using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OICPen
{
    public partial class Staffs : Form
    {
        private Services.StaffService Servis;
        private StaffT staff;

        public StaffT Staff
        {
            set
            {
                staff = value;
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
            Utility.TextBoxDigitCheck(idTbox, e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var staffs = new string[] { searchNameTbox.Text, idTbox.Text, searchFuriganaTbox.Text };
            var processes = new Func<List<Models.StaffT>>[]
            {

                 //名前での検索
                () =>
                    Servis.FindByName(searchNameTbox.Text),

               // IDでの検索
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
            if (itemCount > 1)
            {
                MessageBox.Show("検索項目が一つではありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (itemCount == 0)
            {
                SetDataGridView(Servis.GetAllStaffs());
            }
            else
            {
                try
                {
                    string erroMessage = "";
                    if (currentIndex == 2)
                    {
                        if ((erroMessage = Utility.HiraganaCheck(searchFuriganaTbox.Text)) != "")
                        {
                            MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
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
                catch { }
            }

        }

        private void SetDataGridView(List<Models.StaffT> staffs)
        {
            staffsDgv.Rows.Clear();
            staffs.ForEach(staff =>
            {
                staffsDgv.Rows.Add(
                    staff.StaffTID,
                    staff.Name,
                    staff.Hurigana,
                    staff.Permission
                    );
            });
        }

        private void Staffs_Load(object sender, EventArgs e)
        {
            idTbox.Focus();
            DataShow();
        }

        //社員の登録
        private void registerBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (
                !Utility.TextIsEmpty(registerNameTbox.Text)
                && !Utility.TextIsEmpty(registerNameTbox.Text)
                && !Utility.TextIsEmpty(registerFuriganaTbox.Text)
                && !Utility.TextIsEmpty(passwordLbl.Text)
                && !Utility.TextIsEmpty(password2Tbox.Text)
                && !Utility.TextIsEmpty(permissionCbox.Text)
                )
            {
                if (passwordTbox.Text != password2Tbox.Text)
                {
                    MessageBox.Show("パスワードが一致しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTbox.Clear();
                    password2Tbox.Clear();
                    return;
                }

                if ((errorMessage = Utility.HiraganaCheck(registerFuriganaTbox.Text)) == "")
                {
                    Servis.AddStaff(TextToStaff());
                    registerNameTbox.Text = "";
                    registerFuriganaTbox.Text = "";
                    passwordTbox.Text = "";
                    password2Tbox.Text = "";
                    MessageBox.Show("登録しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("全項目を入力しないといけません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            staff.Hurigana = registerFuriganaTbox.Text;
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
            registerFuriganaTbox.Text = staff.Hurigana;
            permissionCbox.SelectedIndex = (int)cells[3].Value;
            //Dgvの権限を日本語で表示する。
            //Dgvからパスワードを登録・更新テキストボックスに表示する？
        }

        //社員の修正
        private void fixBtn_Click(object sender, EventArgs e)
        {
            if (idDispLbl.Text == "")
            {
                MessageBox.Show("社員を選択しないままの更新はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            uint checkAllEntered = 0;
            var staffs= new string[] { registerNameTbox.Text, registerFuriganaTbox.Text, passwordTbox.Text, password2Tbox.Text };
            for (uint i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != "")
                {
                    checkAllEntered++;
                }
            }
            if (checkAllEntered != 4){
                MessageBox.Show("全項目を入力しないといけません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string erroMessage = "";
            if ((erroMessage = Utility.HiraganaCheck(registerFuriganaTbox.Text)) != "")
            {
                MessageBox.Show(erroMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(idDispLbl.Text);
            if (id == staff.StaffTID)
            {
                MessageBox.Show("自分自身を修正することはできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var afterStaff = TextToStaff();
            var beforeStaff = Servis.FindByID(id);
            beforeStaff.Name = afterStaff.Name;
            beforeStaff.Hurigana = afterStaff.Hurigana;
            beforeStaff.Permission = afterStaff.Permission;
            Servis.UpdateStaff(beforeStaff);
            DataShow();
            registerNameTbox.Clear();
            registerFuriganaTbox.Clear();
            passwordTbox.Clear();
            password2Tbox.Clear();
        }

        //社員の削除
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idDispLbl.Text == "")
            {
                MessageBox.Show("社員を選択しないままの削除はできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(idDispLbl.Text);
            if (id == staff.StaffTID)
            {
                MessageBox.Show("自分自身を削除することはできません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Servis.DeleteStaff(id);
            DataShow();
            idDispLbl.Text = "";
            registerNameTbox.Text = "";
            registerFuriganaTbox.Text = "";
            permissionCbox.SelectedIndex = -1;
        }
    }
}
