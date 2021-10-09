﻿using SharpBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpBank.Web.Services
{
    public interface IAccountServices
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}
