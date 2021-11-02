using Ji.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Menu
{
    public partial class frmSaleOff : ClientForm
    {
        public string type { get; set; }
        public int SaleOff { get; set; }
        public frmSaleOff()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtSaleOff.Text.IsNumber())
            {
                int sale = txtSaleOff.Text.VNDToNumber();
                if (sale<0||sale>50)
                {
                    UI.Warning("Giảm giá phải từ 0% - 50%");
                    return;
                }
                SaleOff = sale;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                UI.Warning("Giảm giá phải là số");
        }

        private void frmSaleOff_Load(object sender, EventArgs e)
        {

        }
    }
}
