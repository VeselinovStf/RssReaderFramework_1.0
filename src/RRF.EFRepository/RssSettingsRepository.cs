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
    public class RssSettingsRepository : IEFRepository<RssSetting>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public RssSettingsRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<RssSetting>> GetSetAsync(string id)
        {
            return await this.dbContext.RssSettings.ToListAsync();
        }

        public async Task<RssSetting> GetSingleAsync(string rssSetting)
        {
            Validator.StringIsNullOrEmpty(rssSetting);

            var userSettings = await this.dbContext
                .RssSettings
                .Include(x => x.DescendantElement)
                .FirstOrDefaultAsync(s => s.ClientId.ToString() == rssSetting);

            return userSettings;
        }
    }
}