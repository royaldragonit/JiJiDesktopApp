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
using RestSharp;
using System.Net;
using Ji.Revenue.Models;
using Ji.Revenue;
using Ji.Services.Interface;
using Ji.Model.Entities;

namespace Ji.Customer
{
    public partial class ucCustomer : ClientControl
    {
        private readonly ICustomerServices _customerServices;
        public ucCustomer()
        {
            InitializeComponent();
            _customerServices = _customerServices.GetServices();
            LoadData();
        }
        private void LoadData()
        {
            List<LCustomer> data = _customerServices.ListCustomer();
              gridControl1.DataSource = data;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewCustomer frm = new frmNewCustomer();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            int CustomerID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToInt();
            using (frmRevenueCustomer frm = new frmRevenueCustomer())
            {
                frm.CustomerID = CustomerID;
                frm.ShowDialog();
            }
        }
    }
}
