﻿using _web_api_project.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Persistence.Interfaces
{
    public interface IAccountRepository
    {
        public void AddAcountToDatabase(Account account);
        public Account FindAccountInDatabase(string username);
        public Account FindAccountById(Guid id);

    }
}
