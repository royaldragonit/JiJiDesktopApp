using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.LoginModels
{
    public class LoginResultModel
    {
        public LUsers User { get; set; }
        public string Token { get; set; }
    }
}
