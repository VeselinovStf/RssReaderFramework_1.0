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
       
        private readonly IFeed<IFeedNode> feedDb;

        public FeedNodeRepository(          
            IFeed<IFeedNode> feedDb)
        {         
            this.feedDb = feedDb;
        }

        public  IEnumerable<IFeedNode> GetListedFeed()
        {
            var rssFeed = this.feedDb.GetAll();
           
            return rssFeed;
        }

        //TODO: REMOVE THIS
        //public async Task<IEnumerable<IFeedNode>> GetSpecificFeed(string RSSURL, string descendantElementName)
        //{
        //    var RSSData = this.webClient.DownloadString(RSSURL);

        //    var xml = this.xDocument.Parse(RSSData);

        //    var RSSFeedData = await this.rssFeedModelFactory
        //        .Create(xml.Descendants(descendantElementName));

        //    return RSSFeedData;
        //}
    }
}