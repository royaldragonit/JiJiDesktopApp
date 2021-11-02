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
using RestSharp;
using System.Net;

namespace Ji.Poached
{
    public partial class ucMaterial : ClientControl, IClientControl
    {
        List<Resource> ds = new List<Resource>();
        public ucMaterial()
        {
            InitializeComponent();
            BindingData();
        }

        private void ucMaterial_SizeChanged(object sender, EventArgs e)
        {
            pcBotLeft.Width = this.Width / 2 - 1;
        }

        private void RadioPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioPrice.Properties.Items[RadioPrice.SelectedIndex].Value.ToString().ToInt() == 1)
            {
                txtPrice.Visible = true;
            }
            else
            {
                //string Price = db.L_Food.AsEnumerable().FirstOrDefault(x => x.ID == SearchFood.EditValue.ToInt()).Price.ToVND();
                //RadioPrice.Properties.Items[RadioPrice.SelectedIndex].Description = Price;
                txtPrice.Visible = false;
            }
        }
        /// <summary>
        /// Hàm xem lịch sử nhập hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SearchFood.EditValue != null)
            {
                using (frmViewHistoryGoods frm = new frmViewHistoryGoods())
                {
                    frm.ResourceID = SearchFood.EditValue.ToInt();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
            else
                UI.Warning("Bạn chưa chọn nguyên liệu xem lịch sử");
        }
        private HistoryImportResource GetHistoryImport(int resourceID)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Poached/GetLastImport");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
            request.AddParameter("ResourceID", resourceID);
            var response = client.Post<HistoryImportResource>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        public void LoadControl()
        {
            throw new NotImplementedException();
        }

        public void BindingData()
        {
            List<Resource> ds = API.GetResources<Resource>()?.ToList();
            this.ds = ds;
            SearchFood.Properties.DataSource = null;
            SearchFood.Properties.DataSource = ds;
            SearchFood.Properties.ValueMember = "ID";
            SearchFood.Properties.DisplayMember = "Name";
            gridControl1.DataSource = null;
            gridControl1.DataSource = ds;
            if (ds != null && ds.Count > 0)
            {
                SearchFood.EditValue = ds[0].ID;
                RadioPrice.Properties.Items[0].Description = ds[0].Price.ToVND();
            }
        }
        /// <summary>
        /// Khi chọn nguyên liệu thì Binding Data tương ứng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFood_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = SearchFood.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = "ID"; // or other field name  
            int ResourceID = view.GetRowCellValue(rowHandle, fieldName).ToInt();
            Resource resource = ds.FirstOrDefault(x => x.ID == ResourceID);
            var GetHistory=GetHistoryImport(ResourceID);
            if (GetHistory != null)
            {
                lblTextHistory.Text = "Lần cuối nhập hàng vào ngày " + GetHistory.CreateBy.ToString() + " - SL: " + GetHistory.Quantity + " - Giá: " + GetHistory.Price;
            }
            else
                lblTextHistory.Text = "Mặt hàng này chưa có dữ liệu nhập";
            if (resource != null)
            {
                txtQuantity.Text = "1";
                txtPoached.Text = ((float)resource.Quantity/resource.QuantityInAUnit).ToString();
                RadioPrice.Properties.Items[0].Description = resource.Price.ToVND();
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            using (frmAddResource frm = new frmAddResource())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindingData();
                }
            }
        }
        /// <summary>
        /// Khi thay đổi dòng trong GridControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            UI.ShowSplashForm();
            if (SearchFood.EditValue != null)
            {
                if (txtQuantity.Text.ToInt() <= 0)
                {
                    UI.Warning("Số lượng phải > 0");
                    return;
                }
                int Price = 0;
                int PriceOld = RadioPrice.Properties.Items[0].Description.VNDToNumber();
                if (txtPrice.Visible == true)
                {
                    if (txtPrice.Text.ToInt() <= 0)
                    {
                        UI.Warning("giá mới phải > 0");
                        return;
                    }
                    Price = txtPrice.Text.ToInt();
                }
                else
                    Price = RadioPrice.Properties.Items[0].Description.VNDToNumber();
                int rs = AddResourcePoached(SearchFood.EditValue.ToInt(), txtQuantity.Text.ToInt(), Price, PriceOld);
                if (rs == 2)
                {
                    BindingData();
                    UI.SaveInformation();
                }
                else
                    UI.Warning("Lỗi! Chưa nhập hàng được, vui lòng liên hệ Supporter Ji Ji");
            }
            else
                UI.Warning("Bạn chưa chọn nguyên liệu để nhập");
            UI.CloseSplashForm();
        }
        private int AddResourcePoached(int ResourceID, int Quantity,int Price,int PriceOld)
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Poached/AddResourcePoached");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("Quantity", Quantity);
            request.AddParameter("Price", Price);
            request.AddParameter("PriceOld", PriceOld);
            request.AddParameter("ResourceID", ResourceID);
            var response = client.Post(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Content.VNDToNumber();
            return 0;
        }
        private void txtQuantity_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
                e.Cancel = true;
        }

        private void txtPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
                e.Cancel = true;
        }
    }
}
