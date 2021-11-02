using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Customer
{
  public partial class frmRevenueCustomer : ClientForm
  {

    public frmRevenueCustomer()
    {
      InitializeComponent();
    }

    public int CustomerID { get; set; }

    private void frmRevenueCustomer_Load(object sender, EventArgs e)
    {
      ucRevenueCustomer uc = new ucRevenueCustomer();
      uc.CustomerID = CustomerID;
      uc.Dock = DockStyle.Fill;
      Controls.Add(uc);
    }
  }
}
