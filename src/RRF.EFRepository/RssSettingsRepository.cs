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
    public class RssSettingsRepository : IEFRepository<RssSettings>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public RssSettingsRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<RssSettings>> GetSetAsync()
        {
            return await this.dbContext.RssSettings.ToListAsync();
        }

        public async Task<RssSettings> GetSingleAsync(string rssSetting)
        {
            Validator.StringIsNullOrEmpty(rssSetting);

            return await this.dbContext
                .RssSettings
                .FirstOrDefaultAsync(s => s.UserId.ToString() == rssSetting);
        }
    }
}