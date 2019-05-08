using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.EFService.RssChanelService.Abstract;
using RRF.GuardValidator;
using RRF.RRFDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.EFService.RssChanelService
{
    public class RssChanelService : IRssChanelService
    {
        private readonly IEFRepository<RssChannel> rssChannelRepository;

        public RssChanelService(IEFRepository<RssChannel> rssChannelRepository)
        {
            this.rssChannelRepository = rssChannelRepository;
        }

        public async Task<IEnumerable<RssChannel>> GetAll(string userId)
        {
            Validator.StringIsNullOrEmpty(userId);

            var call = await this.rssChannelRepository.GetSetAsync();

            return call
                .Where(c => c.UserId.ToString() == userId);
        }
    }
}