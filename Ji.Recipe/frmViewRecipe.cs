using Ji.Core;
using Ji.Model.Entities;
using Ji.Services.Interface;
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

namespace Ji.Recipe
{
    public partial class frmViewRecipe : ClientForm
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public int FoodID { get; set; }
        public Model.Recipe Recipe { get; set; }
        public IRecipeServices _recipeServices;

        public frmViewRecipe()
        {
            InitializeComponent();
        }
        private void frmViewRecipe_Load(object sender, EventArgs e)
        {
            Text += " " + RecipeName;
            LoadData();
        }
        private void LoadData()
        {
            List<ji_GetResourceRecipeResult> ds = _recipeServices.ListResourceRecipe(RecipeID);
            gridControl1.DataSource = ds;
            if (ds.Count() > 0)
                txtRecipe.Text = ds?[0]?.Note ?? "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddResourceRecipe frm = new frmAddResourceRecipe();
            frm.recipe = this.Recipe;
            frm.RecipeName = RecipeName;
            frm.FoodID = FoodID;
            if(frm.ShowDialog()==DialogResult.OK)
            {
                LoadData();
            }
        }
        /// <summary>
        /// Hàm xóa món khỏi công thức
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ResourcesID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ResourcesID").ToInt();
            var client = new RestClient(Extension.GetAppSetting("API") + "Recipe/RemoveResource");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", API.TokenType + API.AccessToken);
            request.AddParameter("ResourcesID", ResourcesID);
            var response = client.Post(request);
            int ds = 0;
            if (response.StatusCode == HttpStatusCode.OK)
                ds = response.Content.VNDToNumber();
            else
                ds = -1;
            if (ds > 0)
                LoadData();
        }
    }
}
