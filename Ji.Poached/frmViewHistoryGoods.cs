using Ji.Core;
using Ji.Views;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Poached
{
    public partial class frmViewHistoryGoods : ClientForm
    {
        public int ResourceID { get; set; }
        public frmViewHistoryGoods()
        {
            InitializeComponent();
        }

        private void frmViewHistoryGoods_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //var ds = GetHistoryImport();
            //gridControl1.DataSource = null;
            //gridControl1.DataSource = ds;
        }
        
    }
}
