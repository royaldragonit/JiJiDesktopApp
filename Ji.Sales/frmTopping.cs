using Ji.Core;
using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Sales
{
    public partial class frmTopping : ClientForm
    {
        public string FoodName = "";
        public int FoodID = -1;
        public int Floor = -1;
        public int Table = -1;
        public frmTopping()
        {
            InitializeComponent();
            var ds = API.API_GetAllTopping<LTopping>(Extension.GetAppSetting("API") + "Application/GetAllTopping");
            ChooseTopping.DataSource = ds;
            ChooseTopping.ValueMember = "ID";
            ChooseTopping.DisplayMember = "ToppingName";
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            int[] listID = new int[ChooseTopping.CheckedItems.Count+1];
            int i = 0;
            foreach (LTopping item in ChooseTopping.CheckedItems )
            {
                listID[i++] = item.Id;
            }
            if (listID.Count() == 0)
            {
                
            }
            else
            {

            }
            DialogResult = DialogResult.OK;
        }

        private void frmTopping_Load(object sender, EventArgs e)
        {
            Text = Text + " " + FoodName;
        }
    }
}
