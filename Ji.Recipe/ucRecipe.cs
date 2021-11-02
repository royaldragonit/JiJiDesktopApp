using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ji.Core;
using DevExpress.XtraGrid.Views.Grid;
using RestSharp;
using System.Net;

namespace Ji.Recipe
{
    public partial class ucRecipe : ClientControl
    {
        private int FoodID { get; set; } = 0;
        public ucRecipe()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var ds = API.GetAllFood<L_Food>(Extension.GetAppSetting("API") + "Application/GetAllFood", API.Access_Token);
            SearchFood.Properties.DataSource = null;
            SearchFood.Properties.ValueMember = "ID";
            SearchFood.Properties.DisplayMember = "FoodName";
            SearchFood.Properties.DataSource = ds;
            var dataSource = SetDataSourceGridControl<GetRecipe>();
            gridControl1.DataSource = dataSource;
        }
        private IEnumerable<T> SetDataSourceGridControl<T>()
        {
            var client = new RestClient(Extension.GetAppSetting("API") + "Recipe/GetRecipe");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", API.Token_Type + API.Access_Token);
            var response = client.Post<List<T>>(request);
            if (response.StatusCode == HttpStatusCode.OK)
                return response.Data;
            return null;
        }
        /// <summary>
        /// Hàm xem chi tiết công thức
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            int RecipeID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToInt();
            int FoodID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FoodID").ToInt();
            string RecipeName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FoodName").ToString();
            string Note = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Note").ToString();
            frmCheckAdministrator frm = new frmCheckAdministrator();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Model.Recipe recipe = new Model.Recipe();
                recipe.Note = Note;
                recipe.ID = RecipeID;
                recipe.FoodID = FoodID;
                frmViewRecipe frmViewRecipe = new frmViewRecipe();
                frmViewRecipe.RecipeID = RecipeID;
                frmViewRecipe.FoodID = FoodID;
                frmViewRecipe.Recipe = recipe;
                frmViewRecipe.RecipeName = RecipeName;
                frmViewRecipe.ShowDialog();
            }
        }
        /// <summary>
        /// Hàm thêm công thức
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (FoodID == 0)
            {
                UI.Warning("Bạn chưa chọn món để làm công thức");
                return;
            }
            using (frmAddResourceRecipe frm = new frmAddResourceRecipe())
            {
                UI.ShowSplashForm();
                Model.Recipe recipe = API.AddRecipe(DateTime.Now, FoodID);
                if(recipe==null)
                {
                    UI.Warning("Lỗi khi thêm công thức, vui lòng thử lại hoặc liên hệ Supporter Ji Ji");
                    return;
                }
                frm.RecipeName = SearchFood.EditValue.ToString();
                frm.FoodID = FoodID;
                frm.recipe = recipe;
                UI.CloseSplashForm();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void SearchFood_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = SearchFood.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = "ID"; // or other field name  
            FoodID = view.GetRowCellValue(rowHandle, fieldName).ToInt();
        }
    }
}
