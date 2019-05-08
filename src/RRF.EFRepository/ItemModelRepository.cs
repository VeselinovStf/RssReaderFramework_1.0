using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.GuardValidator;
using RRF.RRFDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.EFRepository
{
    public class ItemModelRepository : IEFRepository<ItemModel>
    {
        private readonly RRFDbContext.RRFDbContext dbContext;

        public ItemModelRepository(RRFDbContext.RRFDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ItemModel>> GetSetAsync()
        {
            return await this.dbContext.ItemModels.ToListAsync();
        }

        public async Task<ItemModel> GetSingleAsync(string rssSetting)
        {
            Validator.StringIsNullOrEmpty(rssSetting);

            return await this.dbContext
                .ItemModels
                .FirstOrDefaultAsync(s => s.ItemRssSetting.UserId.ToString() == rssSetting);
        }
    }
}