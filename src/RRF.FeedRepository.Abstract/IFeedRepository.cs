using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.FeedRepository.Abstract
{
    public interface IFeedRepository<T>
    {
        Task<IEnumerable<IEnumerable<T>>> GetListedFeed(string descendantElementName);

        Task<IEnumerable<T>> GetSpecificFeed(string RSSURL, string descendantElementName);
    }
}