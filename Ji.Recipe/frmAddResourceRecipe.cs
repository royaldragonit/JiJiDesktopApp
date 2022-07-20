using DevExpress.XtraGrid.Views.Grid;
using Ji.Core;
using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.RecipeModels;
using Ji.Services.Interface;
using Ji.Views;
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
        public Model.RecipeModels.Recipe recipe { get; set; }
        public int FoodID { get; set; }
        public readonly IRecipeServices _recipeServices;
        public readonly IInventoryServices _inventoryServices;
        public frmAddResourceRecipe()
        {
            InitializeComponent();
            _recipeServices= _recipeServices.GetServices();
            _inventoryServices = _inventoryServices.GetServices();
            Text += " " + RecipeName;
            LoadData();
        }
        private void LoadData()
        {
            IEnumerable<Resource> data = _inventoryServices.GetResources();
            SearchResource.Properties.DataSource = null;
            SearchResource.Properties.ValueMember = "ID";
            SearchResource.Properties.DisplayMember = "Name";
            SearchResource.Properties.DataSource = data;
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
                ResultCustomModel<bool> result = _recipeServices.AddResourceRecipe(resources);
                if (!result.Success)
                {
                    UI.Warning(result.Message["vn"]);
                    SearchResource.EditValue = null;
                    txtQuantity.Text = "0";
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
