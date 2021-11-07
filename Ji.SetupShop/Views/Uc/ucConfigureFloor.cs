using Ji.Commons;
using Ji.Core;
using Ji.Model.Entities;
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

namespace Ji.SetupShop.Views.Uc
{
    public partial class ucConfigureFloor : UserControl
    {
        private readonly ISystemServices _systemServices;
        public ucConfigureFloor()
        {
            _systemServices = _systemServices.GetServices();
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowSelected = gridView1.FocusedRowHandle;
            int floorId = gridView1.GetRowCellValue(rowSelected, "Id").ToInt();
            bool isRemove = _systemServices.DeleteFloor(floorId);
            if (isRemove)
            {
                Configure.SetupFloor.Remove(Configure.SetupFloor.FirstOrDefault(x => x.Id == floorId));
                gridControl1.DataSource = Configure.SetupFloor;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtZone.Text) && txtNumberTable.Text.IsNumber())
            {
                int rowSelected = gridView1.FocusedRowHandle;
                int floorId = gridView1.GetRowCellValue(rowSelected, "Id").ToInt();
                bool isModify = _systemServices.ModifyFloor(txtZone.Text, txtNumberTable.Text.ToInt(), floorId);
                if (isModify)
                {
                    var floor = Configure.SetupFloor.FirstOrDefault(x => x.Id == floorId);
                    Configure.SetupFloor.Remove(floor);
                    floor.Name = txtZone.Text;
                    floor.CountTable = txtNumberTable.Text.ToInt();
                    //add lại sau khi chỉnh sửa xong
                    Configure.SetupFloor.Add(floor);
                    gridControl1.DataSource = Configure.SetupFloor;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtZone.Text) && txtNumberTable.Text.IsNumber())
            {
                int floorId = _systemServices.AddFloor(txtZone.Text, txtNumberTable.Text.ToInt());
                if (floorId > 0)
                {
                    var floor = new LFloor();
                    floor.Id = floorId;
                    floor.FacId = Configure.Setup.FacId;
                    floor.CountTable = txtNumberTable.Text.ToInt();
                    floor.Name = txtZone.Text;
                    Configure.SetupFloor.Add(floor);
                    gridControl1.DataSource = Configure.SetupFloor;
                }
            }
        }

        private void ucConfigureFloor_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Configure.SetupFloor;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //Trường hợp nút click
            if (string.IsNullOrEmpty(e.Column.FieldName))
            {
                e.Handled = false;
                return;
            }
            txtZone.Text = gridView1.GetRowCellValue(e.RowHandle, "Name").ToString();
            txtNumberTable.Text = gridView1.GetRowCellValue(e.RowHandle, "CountTable").ToString();
        }
    }
}
