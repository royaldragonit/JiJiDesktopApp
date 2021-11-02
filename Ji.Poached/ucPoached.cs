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

namespace Ji.Poached
{
    public partial class ucPoached : ClientControl
    {
        public bool CheckData = true;
        public ucPoached()
        {
            InitializeComponent();
            BindingData();
        }

        public void BindingData()
        {
            var ds = API.GetAllFood<L_Food>(Extension.GetAppSetting("API") + "Application/GetAllFood", API.Access_Token).ToList();
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
                string Price = API.GetPriceFood(SearchFood.EditValue.ToInt());
                RadioPrice.Properties.Items[RadioPrice.SelectedIndex].Description = Price;
                txtPrice.Visible = false;
            }
        }

        private void SearchFood_EditValueChanged(object sender, EventArgs e)
        {
            int FoodID = ((DevExpress.XtraEditors.Controls.ChangingEventArgs)e).NewValue.ToInt();
        }
    }
}
