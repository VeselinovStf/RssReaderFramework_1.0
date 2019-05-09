using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RRF.EFRepository
{
    public class FormatElementsRepository : IEFRepository<XElementModel>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public FormatElementsRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<XElementModel>> GetSetAsync(string rssSetting)
        {
            var call = await this.dbContext
              .RssSettings
              .Include(f => f.RssFormatElements)
              .FirstOrDefaultAsync(s => s.ClientId.ToString() == rssSetting);

            return call.RssFormatElements;
        }

        public async Task<XElementModel> GetSingleAsync(string rssSetting)
        {
            throw new NotFiniteNumberException();
        }
    }
}
