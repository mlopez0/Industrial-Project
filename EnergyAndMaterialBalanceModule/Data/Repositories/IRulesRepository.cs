﻿using EnergyAndMaterialBalanceModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Git comment
namespace EnergyAndMaterialBalanceModule.Data.Repositories
{
    interface IRulesRepository
    {
        Task<IEnumerable<Rules>> GetAllRules();
        Task<IEnumerable<Rules>> GetAllFormulas();
    }
}
