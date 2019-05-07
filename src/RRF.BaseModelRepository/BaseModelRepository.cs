using RRF.BaseModelRepository.Abstract;
using RRF.Feed.Abstract;
using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
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
        private readonly RRFDbContext.RRFDbContext context;

        public BaseModelRepository(
            IWebClientWrapper webClient,
            IXDocumentWrapper xDocument,
            IFeedModelFactory<IBaseModel> rssFeedModelFactory,
            RRFDbContext.RRFDbContext context
            )
        {
            this.webClient = webClient;
            this.xDocument = xDocument;
            this.rssFeedModelFactory = rssFeedModelFactory;
            this.context = context;
        }

        //TODO: REMOVE ITEM string
        public async Task<IEnumerable<IEnumerable<IBaseModel>>> GetListedFeed()
        {
            var RSSFeedData = new List<List<IBaseModel>>();

            //TODO: Extract call to context
            foreach (var feed in this.context.Feeds)
            {
                var RSSData = this.webClient.DownloadString(feed.Feeds.Url);

                var xml = this.xDocument.Parse(RSSData);

                var a = await this.rssFeedModelFactory
                    .Create(xml.Descendants("item"));

                RSSFeedData.Add(a.ToList());
            }

            return RSSFeedData;
        }
    }
}
