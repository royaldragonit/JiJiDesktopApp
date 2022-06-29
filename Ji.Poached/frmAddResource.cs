using Ji.Core;
using Ji.Model.CustomModels;
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

namespace Ji.Poached
{
    public partial class frmAddResource : ClientForm
    {
        private readonly IInventoryServices _inventoryServices;
        public frmAddResource()
        {
            _inventoryServices = _inventoryServices.GetServices();
            InitializeComponent();
            cbUnit.SelectedIndex = 0;
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (UI.Question("Bạn có muốn thoát không?"))
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrandName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtQuantityInAUnit.Text) && !string.IsNullOrEmpty(txtResourceName.Text))
            {
                if (txtPrice.Text.IsNumber() && txtQuantityInAUnit.Text.IsNumber() && txtQuantity.Text.IsNumber() && txtQuantity.Text.ToInt() > 0 && txtPrice.Text.ToInt() > 0 && txtQuantityInAUnit.Text.ToInt() > 0)
                {
                    if (UI.Question("Bạn có chắc là thêm nguyên liệu này không?"))
                    {
                        Resource resource = new Resource();
                        resource.QuantityInAUnit = txtQuantityInAUnit.Text.ToInt();
                        resource.SupplierName = txtBrandName.Text;
                        resource.Quantity = txtQuantity.Text.ToInt();
                        resource.Price = txtPrice.Text.ToInt();
                        resource.Name = txtResourceName.Text;
                        resource.MoneyInAUnit = (double)txtPrice.Text.ToInt() / txtQuantity.Text.ToInt();
                        resource.Unit = cbUnit.SelectedItem.ToString();
                        ResultCustomModel<bool> rs = _inventoryServices.AddResource(resource);
                        if (rs.Success)
                            UI.SaveInformation();
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                    UI.Warning("Số lượng và giá phải là số nguyên");
            }
            else
                UI.Warning("Bạn phải nhập đầy đủ thông tin");
        }
        private void txtPrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
            {
                e.Cancel = true;
                return;
            }
        }

        private void txtQuantity_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
            {
                e.Cancel = true;
                return;
            }
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                if (!string.IsNullOrEmpty(txtPrice.Text) && txtPrice.Text.ToInt() > 0)
                {
                    txtPriceBinding.Text = ((float)(txtPrice.Text.ToInt() / txtQuantity.Text.ToInt())).ToVND();
                }
                else
                {
                    UI.Warning("Vui lòng nhập giá tiền nguyên liệu trước!");
                    e.Cancel = true;
                }
            }
        }

        private void txtQuantityInAUnit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
