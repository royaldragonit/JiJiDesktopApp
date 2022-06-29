using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.FacModels;
using Ji.Model.LoginModels;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class FacServices : IFacServices
    {
        public ResultCustomModel<bool> ListFacility()
        {
            throw new NotImplementedException();
        }

        public ResultCustomModel<LoginRequest> Register(RegisterFacility facility)
        {
            var data = API.Post<ResultCustomModel<LoginRequest>>(UrlApi.FacRegister, facility);
            return data;
        }
    }
}
