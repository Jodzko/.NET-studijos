﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Services.Interfaces
{
    public interface IAccountService
    {
        public bool SignupNewAccount(string username, string password);
        public bool Login(string username, string password);

    }
}
