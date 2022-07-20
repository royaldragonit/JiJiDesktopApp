using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji;
using System.Data.SqlClient;
using Ji.Core;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using Ji.Services.Interface;
using Ji.Model.RecipeModels;
using Ji.Model.CustomModels;
using Ji.Views;

namespace Ji_CongThuc
{
    public partial class ucCongThuc : ClientControl
    {
        private string CongThucID;
        private readonly IProductServices  _productServices;
        private readonly IRecipeServices  _recipeServices;
        public ucCongThuc()
        {
            _productServices = _productServices.GetServices();
            _recipeServices = _recipeServices.GetServices();
            InitializeComponent();
            LoadCongThuc();
            LoadCategory();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string Item(DataRow row, string column)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains(column))
                {
                    if (row.RowState != DataRowState.Deleted)
                        return row[column] + "";
                }
            }
            return string.Empty;
        }
        private void LoadCongThuc()
        {
            //var ds = db.ji_LoadMilk().ToList();
            var ds = _recipeServices.ListRecipe();
            gridControl1.DataSource = ds;
        }
        /// <summary>
        /// Hàm load danh mục Category
        /// </summary>
        private void LoadCategory()
        {
            var ds = _productServices.ListCategory();
            searchLookUpEdit1.Properties.DataSource = ds;
        }
        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.Trim();
            gridControl1.Filter(s.Replace("$", ""));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            memoTP.Text = "";
            memoCT.Text = "";
            searchLookUpEdit1.Text = "";
            CongThucID = "";
            txtGia.Text = "";
            txtLoai.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1.EditValue == null || searchLookUpEdit1.EditValue == "")
            {
                MessageBox.Show("Vui lòng không được để trống");
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            if (memoTP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thành phần");
                return;
            }
            if (memoCT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập công thức");
                return;
            }
            if (CongThucID == "")
                CongThucID = Guid.NewGuid().ToString();
            SaveRecipeInput saveRecipe = new SaveRecipeInput();
            saveRecipe.FoodName = txtTen.Text.ToString(); 
            saveRecipe.Component = memoTP.Text.ToString(); 
            saveRecipe.Formula = memoCT.Text.ToString(); 
            saveRecipe.Unit = txtLoai.Text.ToString();
            saveRecipe.Price = txtGia.ToInt();
            saveRecipe.CategoryID = searchLookUpEdit1.EditValue.ToInt();
            saveRecipe.CreateBy = Extension.Setup["userID"].ToInt();
            saveRecipe.FormulaID = Guid.Parse(CongThucID);

            ResultCustomModel<bool> result= _recipeServices.SaveRecipe(saveRecipe);
            if (result.Success)
            {
                AutoCloseMsgbox.Show("Đã lưu", "Thông báo", 500);
                LoadCongThuc();
            }
            else
                UI.Warning("Lỗi! Vui lòng kiểm tra lại");
        }
        /// <summary>
        /// Hàm của nút Áp dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            //var row = gridView1.FocusedRowHandle;
            //string FoodName = gridView1.GetRowCellValue(row, "FoodName").ToString();
            //string ThanhPhan = gridView1.GetRowCellValue(row, "ThanhPhan").ToString();
            //string CongThuc = gridView1.GetRowCellValue(row, "CongThuc").ToString();
            //int Category = gridView1.GetRowCellValue(row, "CategoryID").ToInt();
            //int Price = gridView1.GetRowCellValue(row, "Price").ToInt();
            //string Unit = gridView1.GetRowCellValue(row, "Unit").ToString();
            //string FacID = "0";
            //var ds = db.ji_Food_Save(0, Category, "", true, FoodName, FacID, Unit, Price, 0, 1);
            //int ds=API.SaveFood()
            //AutoCloseMsgbox.Show("Đã áp dụng", "Thông báo", 500);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int row = gridView1.FocusedRowHandle;
            if (row >= 0)
            {
                string Unit = "";
                Unit = gridView1.GetRowCellValue(row, "Unit")?.ToString() ?? "Chưa có";
                string FoodName = gridView1.GetRowCellValue(row, "FoodName").ToString();
                string ThanhPhan = gridView1.GetRowCellValue(row, "ThanhPhan").ToString();
                string CongThuc = gridView1.GetRowCellValue(row, "CongThuc").ToString();
                int Category = gridView1.GetRowCellValue(row, "CategoryID").ToInt();
                int Price = Convert.ToInt32(gridView1.GetRowCellValue(row, "Price"));
                CongThucID = gridView1.GetRowCellValue(row, "CongThucID").ToString();
                txtTen.Text = FoodName;
                memoTP.Text = ThanhPhan;
                memoCT.Text = CongThuc;
                searchLookUpEdit1.EditValue = Category;
                txtGia.Text = Price.ToString(); ;
                txtLoai.Text = Unit;
            }
        }
    }

}
