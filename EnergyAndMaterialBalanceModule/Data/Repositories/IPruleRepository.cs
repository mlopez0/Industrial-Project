using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAndMaterialBalanceModule.Data.Repositories
{
    public interface IPruleRepository
    {
        Task<IEnumerable<Models.Prule>> GetAllRules();
        // Git comment
    }
}
