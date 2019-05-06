using RRF.Feed;
using RRF.Feed.Abstract;
using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
using RRF.FeedRepository.Abstract;
using RRF.WebClientWrapper.Abstract;
using RRF.XDocumentWrapper.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.FeedNodeRepository
{
    public class FeedNodeRepository : IFeedRepository<IFeedNode>
    {
        private readonly IWebClientWrapper webClient;
        private readonly IXDocumentWrapper xDocument;
        private readonly IFeedModelFactory<IFeedNode> rssFeedModelFactory;
        private readonly IFeed<IFeedNode> feedDb;

        public FeedNodeRepository(
            IWebClientWrapper webClient,
            IXDocumentWrapper xDocument,
            IFeedModelFactory<IFeedNode> rssFeedModelFactory,
            IFeed<IFeedNode> feedDb)
        {
            this.webClient = webClient;
            this.xDocument = xDocument;
            this.rssFeedModelFactory = rssFeedModelFactory;
            this.feedDb = feedDb;
        }

        public async Task<IEnumerable<IEnumerable<IFeedNode>>> GetListedFeed(string descendantElementName)
        {
            var rssFeed = this.feedDb.GetAll();

            var RSSFeedData = new List<List<IFeedNode>>();

            foreach (var feed in rssFeed)
            {
                var RSSData = this.webClient.DownloadString(feed.Url);

                var xml = this.xDocument.Parse(RSSData);

                var a = await this.rssFeedModelFactory
                    .Create(xml.Descendants(descendantElementName));

                RSSFeedData.Add(a.ToList());
            }

            return RSSFeedData;
        }

        public async Task<IEnumerable<IFeedNode>> GetSpecificFeed(string RSSURL, string descendantElementName)
        {
            var RSSData = this.webClient.DownloadString(RSSURL);

            var xml = this.xDocument.Parse(RSSData);

            var RSSFeedData = await this.rssFeedModelFactory
                .Create(xml.Descendants(descendantElementName));

            return RSSFeedData;
        }
    }
}