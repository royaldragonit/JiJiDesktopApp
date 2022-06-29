using Ji.Core;
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

namespace Shell.Views.Uc
{
    public partial class ucListFacility : UserControl
    {
        private readonly IFacServices _facServices;
        public ucListFacility()
        {
            _facServices = _facServices.GetServices();
            InitializeComponent();
        }

        private void ucListFacility_Load(object sender, EventArgs e)
        {

        }
    }
}
