using Ji;
using Ji.Core;
using Ji.Model;
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

        public DataTable DataSource { get; set; }
        public frmNewOrder()
        {
            InitializeComponent();
        }
        public void CallOrder()
        {
            bool check = false;
            hubConnection.On<int,int>("CallOrder", (Floor,Table) =>
            {
                if (gridView1.DataSource != null)
                {
                    var ds1 = API.GetDataOrder(Floor, Table).ToDataTable();
                    check = true;
                    var ds = (DataTable)gridView1.DataSource;
                    foreach (DataRow item in ds1.Rows)
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
