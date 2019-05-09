using RRF.EFModels;
using RRF.EFModels.Abstract;
using RRF.EFRepository.Abstract;
using RRF.EFService.RssSettingsService.Abstrtact;
using RRF.GuardValidator;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.RssSettingsService
{
    public class RssSettingsService : IRssSettingsService
    {
        private readonly IEFRepository<RssSetting> rssChannelRepository;

        public RssSettingsService(IEFRepository<RssSetting> rssChannelRepository)
        {
            this.rssChannelRepository = rssChannelRepository;
        }

        public async Task<DescendingElement> GetXElementDescendant(string userId)
        {
            Validator.StringIsNullOrEmpty(userId);

            var call = await this.rssChannelRepository.GetSingleAsync(userId);

            Validator.RssSettingsObjectIsNull(call);

            return  call.DescendantElement;
        }
    }
}
