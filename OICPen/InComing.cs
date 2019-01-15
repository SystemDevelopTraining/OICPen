using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OICPen
{
    public partial class InComing : Form,MyForm
    {
        private Services.InComingService service;
        private Services.GiveOrderService GiveOrderService;
        private StaffT staff;

        public StaffT Staff
        {
            set
            {
                staff = value;
                registerBtn.Enabled = false;
                fixBtn.Enabled = false;
            }
        }

        private bool PermissionOk()
        {
            return staff.Permission == Permission.God
                   || staff.Permission == Permission.PurchasingControl;
        }

        public InComing(Models.OICPenDbContext dbcontext)
        {
            InitializeComponent();
            service = new Services.InComingService(dbcontext);
            GiveOrderService = new Services.GiveOrderService(dbcontext);
            SetDataGridView(service.GetNotYetInComing());
            registerBtn.Enabled = false;
            fixBtn.Enabled = false;
        }

        private void SetDataGridView(List<GiveOrderT> orders)
        {
            incomingDgv.Rows.Clear();
            orders.ForEach(order =>
                incomingDgv.Rows.Add(
                    order.GiveOrderTID,
                    order.GiveOrderDate,
                    order.CompleteDate,
                    order.StaffT.Name
                    )
                );
        }

        private void SetDataGridView(GiveOrderT order)
        {
            incomingDgv.Rows.Add(order.GiveOrderTID, order.GiveOrderDate, order.CompleteDate, order.StaffT);
        }

        private void incomingTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxDigitCheck(incomingTbox, e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (Utility.TextIsEmpty(incomingTbox.Text))
            {
                MessageBox.Show("検索内容を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                incomingDgv.Rows.Clear();
                try
                {
                    SetDataGridView(service.SearchByGiveOrderId(int.Parse(incomingTbox.Text)));
                }
                catch { }
            }
        }

        private void giveOrderedCheckBtn_Click(object sender, EventArgs e)
        {
            if (PermissionOk())
            {
                registerBtn.Enabled = false;
                fixBtn.Enabled = true;
            }
            SetDataGridView(service.GetAlreadyInComming());
        }

        private void giveOrderCheckBtn_Click(object sender, EventArgs e)
        {
            if (PermissionOk())
            {
                registerBtn.Enabled = true;
                fixBtn.Enabled = false;
            }
            SetDataGridView(service.GetNotYetInComing());
        }

        private void fixBtn_Click(object sender, EventArgs e)
        {
            if (incomingDgv.SelectedRows.Count != 0)
            {
                if (incomingDgv.SelectedRows[0].Cells[2].Value != null)
                {
                    if (MessageBox.Show("入庫を取り消しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                        service.CancelInComming(service.SearchByGiveOrderId(int.Parse(incomingDgv.SelectedRows[0].Cells[0].Value.ToString())));
                        SetDataGridView(service.GetNotYetInComing());
                        MessageBox.Show("入庫を取り消しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }else
                {
                    MessageBox.Show("未入庫の発注です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("発注が選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (incomingDgv.SelectedRows.Count != 0)
            {
                if (incomingDgv.SelectedRows[0].Cells[2].Value == null)
                {
                    service.InComining(service.SearchByGiveOrderId(int.Parse(incomingDgv.SelectedRows[0].Cells[0].Value.ToString())));
                    SetDataGridView(service.GetNotYetInComing());
                    MessageBox.Show("入庫しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("入庫済みです", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("発注が選択されていません", "完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void InComing_Load(object sender, EventArgs e)
        {
            giveOrderedCheckBtn.Focus();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.Columns[e.ColumnIndex].Name == "Details" && e.ColumnIndex != -1)
            {
                var f = new GiveOrderDetail(GiveOrderService.FindByID(int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    f.ShowDialog();
            }
        }
    }
}
