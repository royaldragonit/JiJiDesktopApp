using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ji.Core;
using Ji.Model;
using DevExpress.XtraSplashScreen;

namespace Ji.Menu
{
    public partial class ucMenu : ClientControl, IClientControl
    {
        string img { get; set; }
        int FoodID { get; set; }
        bool Status { get; set; }
        public ucMenu()
        {
            InitializeComponent();
            gridView1.IndicatorWidth = 30;
        }
        /// <summary>
        /// Hàm thay đổi hình ảnh của món
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = Extension.ChooseFile("Tệp hình ảnh (*.PNG, *.JPG, *.ICO, *.JPEG)  | *.png;*.jpg;*.ico;*.jpeg", false);
            if (file != null)
            {
                img = file.FileName.ConvertFileToBase64();
            }
        }
        /// <summary>
        /// Thêm món vào Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmSaleOff frm = new frmSaleOff())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        if (txtPrice.Text.IsNumber())
                        {
                            Menus menus = new Menus();
                            menus.cCategoryID = cbCategory.EditValue.ToInt();
                            menus.cSaleOff = frm.SaleOff;
                            menus.cPrice = txtPrice.Text;
                            menus.cStatus = Status;
                            menus.Unit = cbUnit.SelectedItem.ToString();
                            menus.cImage = img;
                            menus.cFoodName = txtName.Text;
                            menus.cCategory = cbCategory.Text;
                            if (API.AddMenu(menus).VNDToNumber() == 1)
                                UI.SaveInformation();
                            else
                                UI.Warning("Đã xảy ra lỗi, vui lòng thử lại hoặc liên hệ Supporter để được trợ giúp");
                        }
                        else
                            UI.Warning("Giá tiền phải là số nguyên");
                    }
                    else
                        UI.Warning("Bạn phải nhập đầy đủ thông tin");
                }
            }
        }

        public void LoadControl()
        {

        }

        public void BindingData()
        {
            IEnumerable<Menus> menu = API.LoadAllMenu<Menus>(Extension.GetAppSetting("API") + "Application/LoadAllMenu", API.Access_Token);
            GridMenu.DataSource = menu;
            if (menu?.Count() > 0)
            {
                gridView1.FocusedRowHandle = 0;
                LoadImage(0);
            }
            LoadCategory();
        }
        private void LoadCategory()
        {
            var ds = API.GetAllCategory<Categories>(Extension.GetAppSetting("API") + "Application/GetAllCategory", API.Access_Token)?.ToList();
            cbCategory.Properties.DisplayMember = "Name";
            cbCategory.Properties.ValueMember = "ID";
            cbCategory.Properties.DataSource = ds;
        }
        private void LoadImage(int row)
        {
            string FileName = gridView1.GetRowCellValue(row, "FileName")?.ToString();
            if (!string.IsNullOrEmpty(FileName))
            {
                pictureEdit1.LoadAsync(Extension.GetAppSetting("Host")+FileName);
                pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                pictureEdit1.Size = new Size(new Point(80,60));
            }
        }
        private void ucMenu_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            LoadData(e.RowHandle);
        }
        private void LoadData(int row)
        {
            FoodID = gridView1.GetRowCellValue(row, "cFoodID")?.ToInt() ?? 0;
            Status = gridView1.GetRowCellValue(row, "cStatus").ToBoolean();
            string data = gridView1.GetRowCellValue(row, "cCategoryID").ToString();
            cbCategory.EditValue = data;
            txtName.Text = gridView1.GetRowCellValue(row, "cFoodName").ToString();
            txtPrice.Text = gridView1.GetRowCellValue(row, "cPrice").ToString().VNDToNumber().ToString();
            LoadImage(row);
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (frmSaleOff frm = new frmSaleOff())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                    {
                        if (txtPrice.Text.IsNumber())
                        {
                            Menus menus = new Menus();
                            menus.cCategoryID = cbCategory.EditValue.ToInt();
                            menus.cSaleOff = frm.SaleOff;
                            menus.cPrice = txtPrice.Text;
                            menus.cStatus = Status;
                            menus.cFoodID = FoodID;
                            menus.Unit = cbUnit.SelectedItem.ToString();
                            menus.cImage = img;
                            menus.cFoodName = txtName.Text;
                            menus.cCategory = cbCategory.Text;
                            int rs = API.UpdateMenu(menus).VNDToNumber();
                            if (rs > 0)
                                UI.SaveInformation();
                            else
                                UI.Warning("Đã xảy ra lỗi, vui lòng thử lại hoặc liên hệ Supporter để được trợ giúp");
                        }
                        else
                            UI.Warning("Giá tiền phải là số nguyên");
                    }
                    else
                        UI.Warning("Bạn phải nhập đầy đủ thông tin");
                }
            }
        }

        private void btnActive_Toggled(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default == null)
                SplashScreenManager.ShowForm(typeof(Pleasewait));
            API.SetActiveMenu(FoodID);
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadData(e.FocusedRowHandle);
        }
    }
}
