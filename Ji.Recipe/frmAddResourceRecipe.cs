using DevExpress.XtraGrid.Views.Grid;
using Ji.Core;
using Ji.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Recipe
{
    public partial class frmAddResourceRecipe : ClientForm
    {
        public string RecipeName { get; set; }
        public Model.Recipe recipe { get; set; }
        public int FoodID { get; set; }
        public frmAddResourceRecipe()
        {
            InitializeComponent();
            Text += " " + RecipeName;
            LoadData();
        }
        private void LoadData()
        {
            var ds = API.GetResources<Resource>();
            SearchResource.Properties.DataSource = null;
            SearchResource.Properties.ValueMember = "ID";
            SearchResource.Properties.DisplayMember = "Name";
            SearchResource.Properties.DataSource = ds;
        }
        /// <summary>
        /// Hàm thêm nguyên liệu vào công thức
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddResource_Click(object sender, EventArgs e)
        {
            if (SearchResource.EditValue != null && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                ResourcesRecipe resources = new ResourcesRecipe();
                resources.PriceCost = txtPriceCost.Text.VNDToNumber();
                resources.Quantity = txtQuantity.Text.ToInt();
                resources.ResourcesID = SearchResource.EditValue.ToInt();
                resources.RecipeID = recipe.ID;
                int rs = API.AddResourceRecipe(txtPriceCost.Text.VNDToNumber(), txtQuantity.Text.ToInt(), SearchResource.EditValue.ToInt(), recipe.ID);
                if (rs == 0)
                {
                    UI.Warning("Nguyên liệu này đã có trong công thức, vui lòng kiểm tra lại");
                    SearchResource.EditValue = null;
                    txtQuantity.Text = "0";
                    return;
                }
                else if (rs == -1)
                {
                    UI.Warning("Đã xảy ra lỗi trong quá trình thêm nguyên liệu, vui lòng liên hệ Admin để biết thêm thông tin");
                    return;
                }
                else
                {
                    if (UI.Question("Đã thêm thành công, bạn có muốn thêm nguyên liệu khác?"))
                    {
                        SearchResource.EditValue = null;
                        txtQuantity.Text = "0";
                    }
                    else
                    {
                        frmAddRecipe frm = new frmAddRecipe();
                        frm.RecipeNote = recipe.Note;
                        frm.RecipeID = recipe.ID;
                        if (frm.ShowDialog() == DialogResult.OK)
                            Close();
                    }
                }
            }
            else
                UI.Warning("Bạn phải nhập đầy đủ thông tin");
        }

        private void SearchResource_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = SearchResource.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = "Unit";
            txtKind.Text = view.GetRowCellValue(rowHandle, fieldName).ToString();
        }

        private void txtQuantity_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!e.NewValue.ToString().IsNumber())
            {
                e.Cancel = true;
                return;
            }
            GridView view = SearchResource.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                string fieldName = "Quantity";
                int Quantity = view.GetRowCellValue(rowHandle, fieldName).ToInt();
                fieldName = "Price";
                int Price = view.GetRowCellValue(rowHandle, fieldName).ToInt();
                txtPriceCost.Text = (((float)Price / Quantity) * txtQuantity.Text.ToInt()).ToVND();
            }
            else
            {
                UI.Warning("Bạn chưa chọn nguyên liệu");
                e.Cancel = true;
            }
        }
    }
}
