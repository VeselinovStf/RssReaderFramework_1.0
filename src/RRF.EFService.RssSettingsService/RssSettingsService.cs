using RRF.EFModels;
using RRF.EFModels.Abstract;
using RRF.EFRepository.Abstract;
using RRF.EFService.RssSettingsService.Abstrtact;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.RssSettingsService
{
    public class RssSettingsService : IRssSettingsService
    {
        private readonly IEFRepository<RssSettings> rssChannelRepository;

        public RssSettingsService(IEFRepository<RssSettings> rssChannelRepository)
        {
            this.rssChannelRepository = rssChannelRepository;
        }

        public async Task<XElementModel> GetXElementDescendant(string userId)
        {
            var call = await this.rssChannelRepository.GetSingleAsync(userId);

            return  call.MainElement;
        }
    }
}
