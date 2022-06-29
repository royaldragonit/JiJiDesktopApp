using Ji.Core;
using Ji.Model;
using Ji.Model.OrderModels;
using Ji.Services.Interface;
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
    public partial class frmChooseTable : ClientForm
    {
        public int FromTable { get; set; }
        public int ToTable { get; set; }
        public bool Result { get; set; }
        public int FromFloor { get; internal set; }
        public IOrderServices _orderServices { get; set; }
        public frmChooseTable()
        {
            InitializeComponent();

        }

        private void btnOk(object sender, EventArgs e)
        {
            if (!txtTable.Text.IsNumber())
                return;
            ToTable = txtTable.Text.ToInt();
            OrderDetailRequest orderDetailRequest = new OrderDetailRequest();
            orderDetailRequest.Table = ToTable;
            orderDetailRequest.Floor = FromFloor;
            var lstData = _orderServices.ListOrderDetail(orderDetailRequest);
            if (lstData.Count==0)
            {

                if (UI.Question("Bạn có chắc chắn chuyển bàn " + FromTable + " đến bàn " + ToTable))
                {
                    bool result = _orderServices.ConvertTable(FromFloor, FromTable, ToTable);
                    Result = result;
                    DialogResult = DialogResult.OK;
                }
            }
            else
                UI.Warning("Bàn này đã Order, vui lòng chọn bàn khác");
        }

        private void txtTable_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
                e.Cancel = true;
        }
    }
}
