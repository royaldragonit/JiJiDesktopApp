using Ji.Core;
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
    public partial class frmAddRecipe : ClientForm
    {
        public int RecipeID { get; set; } = 0;
        public string RecipeNote { get; set; }

        private readonly IRecipeServices _recipeServices;
        public frmAddRecipe()
        {
            InitializeComponent();
            _recipeServices = _recipeServices.GetServices();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecipe.Text))
            {
                var isSuccess = _recipeServices.UpdateRecipe(RecipeID, txtRecipe.Text);
                if (isSuccess.Success)
                {
                    UI.SaveInformation();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    UI.Warning("Lỗi! Vui lòng thử lại nhé");
            }
            else
                UI.Warning("Bạn phải nhập công thức vào");
        }

        private void frmAddRecipe_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RecipeNote))
                txtRecipe.Text = RecipeNote;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RecipeNote))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (UI.Question("Bạn chưa nhập công thức, bạn có muốn thoát không?"))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
