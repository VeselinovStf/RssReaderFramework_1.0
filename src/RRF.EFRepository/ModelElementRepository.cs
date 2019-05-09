using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RRF.EFRepository
{
    public class ModelElementRepository : IEFRepository<ModelElement>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public ModelElementRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<IEnumerable<ModelElement>> GetSetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelElement> GetSingleAsync(string rssSetting)
        {
            var setting =  await this.dbContext
                .RssSettings
                .Include(m => m.RssModelElements)
                .FirstOrDefaultAsync(u => u.ClientId.ToString() == rssSetting);

            return setting.RssModelElements;
        }
    }
}
