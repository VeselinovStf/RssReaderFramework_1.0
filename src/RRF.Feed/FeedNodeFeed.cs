using RRF.Feed.Abstract;
using RRF.FeedModel;
using RRF.FeedModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRF.Feed
{
    public class FeedNodeFeed : IFeed<IFeedNode>
    {
        private readonly IEnumerable<IFeedNode> feedList;

        public FeedNodeFeed(IEnumerable<string> feedList)
        {
            this.feedList = feedList.Select(f => new FeedNode()
            {
                Url = f
            });
        }

        public IEnumerable<IFeedNode> GetAll()
        {
            return this.feedList;
        }
    }
}