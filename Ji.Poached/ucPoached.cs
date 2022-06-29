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
using Ji.Services.Interface;

namespace Ji.Poached
{
    public partial class ucPoached : ClientControl
    {
        public bool CheckData = true;
        private readonly IProductServices _productServices;
        public ucPoached()
        {
            InitializeComponent();
            _productServices = _productServices.GetServices();
            BindingData();
        }

        public void BindingData()
        {
            var ds = _productServices.ListMilkTea();
            if (ds.Count()==0)
            {
                CheckData = false;
                return;
            }
            SearchFood.Properties.DataSource = ds;
            SearchFood.Properties.DisplayMember = "FoodName";
            SearchFood.Properties.ValueMember = "ID";
            SearchFood.EditValue = ds[0].ID;
            string Price = ds.FirstOrDefault(x => x.ID == ds[0].ID).Price.ToVND();
            RadioPrice.Properties.Items[0].Description = Price;
            txtPrice.Visible = false;
        }

        public void LoadControl()
        {

        }

        private void RadioPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioPrice.Properties.Items[RadioPrice.SelectedIndex].Value.ToString().ToInt() == 1)
            {
                txtPrice.Visible = true;
            }
            else
            {
                int price = _productServices.GetPriceFood(SearchFood.EditValue.ToInt());
                RadioPrice.Properties.Items[RadioPrice.SelectedIndex].Description = price.ToVND();
                txtPrice.Visible = false;
            }
        }

        private void SearchFood_EditValueChanged(object sender, EventArgs e)
        {
            int FoodID = ((DevExpress.XtraEditors.Controls.ChangingEventArgs)e).NewValue.ToInt();
        }
    }
}
