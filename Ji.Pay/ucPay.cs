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
using Ji.Services.Interface;
using Ji.Model.Entities;

namespace Ji.Payment
{
    public partial class ucPay : ClientControl, IClientControl
    {
        private readonly IPayServices _payServices;
        public ucPay()
        {
            InitializeComponent();
            _payServices = _payServices.GetServices();
        }

        public void BindingData()
        {
            List<Pay> ds = _payServices.ListPay(DateTime.Now, DateTime.Now);
            gridControl1.DataSource = ds;
            txtDateTime.DateTime = DateTime.Now;
            lblTotalPay.Text = ds.Sum(x => x.Money).ToVND();
        }

        public void LoadControl()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCreateBy.Text) && !string.IsNullOrEmpty(txtReason.Text) && !string.IsNullOrEmpty(txtMoney.Text) && !string.IsNullOrEmpty(txtDateTime.Text))
            {
                Pay p = new Pay();
                p.Money = txtMoney.Text.ToInt();
                p.CreateBy = txtCreateBy.Text;
                p.CTypePay = TypePay.Properties.Items[ChooseType.SelectedIndex].Description;
                p.Time = txtDateTime.Text.ToDateTime();
                p.Reason = txtReason.Text;
                bool isSuccess = _payServices.AddPay(p);
                if (isSuccess)
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
                        var ds = _payServices.ListPay(frm.FromDate, frm.ToDate);
                        gridControl1.DataSource = ds;
                        lblTotalPay.Text = ds.Sum(x=>x.Money).ToVND();
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
