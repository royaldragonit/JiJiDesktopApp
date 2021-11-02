using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Core;
using Ji.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace Ji.Pay
{
    public partial class ucPay : ClientControl, IClientControl
    {
        public ucPay()
        {
            InitializeComponent();
        }

        public void BindingData()
        {
            var ds = API.GetPayToDay<Pays>(Extension.GetAppSetting("API") + "Pay/GetPayToDay", API.Access_Token, DateTime.Now);
            gridControl1.DataSource = null;
            gridControl1.DataSource = ds;
            txtDateTime.DateTime = DateTime.Now;
            int total = 0;
            foreach (var item in ds)
            {
                total += item.Money;
            }
            lblTotalPay.Text = total.ToVND();
        }

        public void LoadControl()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCreateBy.Text) && !string.IsNullOrEmpty(txtReason.Text) && !string.IsNullOrEmpty(txtMoney.Text) && !string.IsNullOrEmpty(txtDateTime.Text))
            {
                bool ds = API.AddPay(Extension.GetAppSetting("API") + "Pay/AddPay", API.Access_Token, txtMoney.Text.ToInt(), txtReason.Text, txtCreateBy.Text, Convert.ToDateTime(txtDateTime.Text), TypePay.Properties.Items[ChooseType.SelectedIndex].Description);
                if (ds)
                {
                    UI.SaveInformation();
                    BindingData();
                }
                else
                    UI.Warning("Lỗi! Vui lòng thử lại sau!");
            }
            else
                UI.Warning("Bạn phải nhập đầy đủ thông tin");
        }
        private void SetRowColorByCondition()
        {
            var ds = (List<Pays>)gridView1.DataSource;
            foreach (var item in ds)
            {

            }
        }
        private void ChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseType.Properties.Items[ChooseType.SelectedIndex].Value.ToString().ToInt() == 1)
            {
                using (frmChooseDate frm = new frmChooseDate())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var ds = API.PayDistanceFromTo<Pays>(Extension.GetAppSetting("API") + "Pay/PayDistanceFromTo", API.Access_Token, frm.FromDate, frm.ToDate);
                        gridControl1.DataSource = null;
                        gridControl1.DataSource = ds;
                        int total = 0;
                        if (ds != null)
                            foreach (var item in ds)
                            {
                                total += item.Money;
                            }
                        lblTotalPay.Text = total.ToVND();

                    }
                }
            }
            //Hôm nay
            else
            {
                BindingData();
            }
        }

        private void ucPay_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["cTypePay"]);
                if (category == "Công nợ")
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }
    }
}
