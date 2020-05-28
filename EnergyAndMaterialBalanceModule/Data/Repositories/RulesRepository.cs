using EnergyAndMaterialBalanceModule.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyAndMaterialBalanceModule.Data.Repositories
{
    public class RulesRepository : BaseRepository<Rules, SEICBalanceContext>, IResourcesRepository
    {
        public RulesRepository(SEICBalanceContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Resources>> GetAllResources()
        {
            return (IEnumerable<Resources>)await GetAll().ToListAsync();
        }

        public async Task<IEnumerable<Resources>> GetAllFormulas()
        {
            return (IEnumerable<Resources>)await GetAll().ToListAsync();

        }

    }
}
