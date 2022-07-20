using Ji;
using Ji.Core;
using Ji.Model;
using Ji.Model.OrderModels;
using Ji.Services.Interface;
using Ji.Views;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell.Views.Frm
{
    public partial class frmNewOrder : ClientForm
    {
        internal HubConnection hubConnection;

        public List<OrderDetail> DataSource { get; set; }
        private readonly IOrderServices _orderServices;
        public frmNewOrder()
        {
            _orderServices = _orderServices.GetServices();
            InitializeComponent();
        }
        public void CallOrder()
        {
            bool check = false;
            hubConnection.On<int,int>("CallOrder", (Floor,Table) =>
            {
                if (gridView1.DataSource != null)
                {
                    var ds1 = _orderServices.GetListOrderByTable(Table, Floor);
                    check = true;
                    var ds = (DataTable)gridView1.DataSource;
                    foreach (var item in ds1)
                    {
                        ds.Rows.Add(item);
                    }
                    gridControl1.DataSource = ds;
                }
            });
            hubConnection.StartAsync();
            if(!check)
                gridControl1.DataSource = DataSource;
        }
        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            CallOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
