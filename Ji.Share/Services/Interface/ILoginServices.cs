﻿using Ji.Model.CustomModels;
using Ji.Model.LoginModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface ILoginServices
    {
        ResultCustomModel<LoginResultModel> UserLogin(LoginRequest login);
        ResultCustomModel<LoginResultModel> SupporterLogin(LoginRequest login);
        ResultCustomModel<LoginResultModel> BHXHLogin(LoginRequest login);
    }
}
