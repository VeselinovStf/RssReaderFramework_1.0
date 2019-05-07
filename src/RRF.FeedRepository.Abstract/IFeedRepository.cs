using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.FeedRepository.Abstract
{
    public interface IFeedRepository<T>
    {
        IEnumerable<T> GetListedFeed();

        //Task<IEnumerable<T>> GetSpecificFeed(string RSSURL, string descendantElementName);
    }
}