using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.GuardValidator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RRF.EFRepository
{
    public class RssChanelRepository : IEFRepository<RssChannel>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public RssChanelRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<RssChannel>> GetSetAsync()
        {
            return await this.dbContext.RssChannels.ToListAsync();
        }

        public async Task<RssChannel> GetSingleAsync(string rssSetting)
        {
            Validator.StringIsNullOrEmpty(rssSetting);

            return await this.dbContext
                .RssChannels
                .FirstOrDefaultAsync(s => s.Client.Id.ToString() == rssSetting);
        }
    }
}