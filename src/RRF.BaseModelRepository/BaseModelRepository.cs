using RRF.BaseModelRepository.Abstract;
using RRF.EFService.RssChanelService.Abstract;
using RRF.EFService.RssSettingsService.Abstrtact;
using RRF.Feed.Abstract;
using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
using RRF.Identity.Models.BaseModel;
using RRF.IdentityUtility.UserManagerUtility.Abstract;
using RRF.Models.BaseModel.Abstract;
using RRF.RRFDbContext;
using RRF.WebClientWrapper.Abstract;
using RRF.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.BaseModelRepository
{
    public class BaseModelRepository : IBaseModelRepository
    {
        private readonly IWebClientWrapper webClient;
        private readonly IXDocumentWrapper xDocument;
        private readonly IFeedModelFactory<IBaseModel> rssFeedModelFactory;
        private readonly IRssChanelService rssChanelService;
        private readonly IRssSettingsService rssSettingsService;

        public BaseModelRepository(
            IWebClientWrapper webClient,
            IXDocumentWrapper xDocument,
            IFeedModelFactory<IBaseModel> rssFeedModelFactory,
            IRssChanelService rssChanelService,
            IRssSettingsService rssSettingsService
            )
        {
            this.webClient = webClient;
            this.xDocument = xDocument;
            this.rssFeedModelFactory = rssFeedModelFactory;
            this.rssChanelService = rssChanelService;
            this.rssSettingsService = rssSettingsService;
        }

       
        public async Task<IEnumerable<IEnumerable<IBaseModel>>> GetListedFeed(string userId)
        {
            var RSSFeedData = new List<List<IBaseModel>>();

            var descendantElement = await this.rssSettingsService.GetXElementDescendant(userId);
        
            foreach (var feed in await this.rssChanelService.GetAll(userId))
            {
                var RSSData = this.webClient.DownloadString(feed.URL);

                var xml = this.xDocument.Parse(RSSData);

                var a = await this.rssFeedModelFactory
                    .Create(xml.Descendants(descendantElement.Name), userId);

                RSSFeedData.Add(a.ToList());
            }

            return RSSFeedData;
        }
    }
}
