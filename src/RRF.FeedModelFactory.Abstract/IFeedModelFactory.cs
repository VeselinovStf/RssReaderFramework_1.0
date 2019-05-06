using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RRF.FeedModelFactory.Abstract
{
    public interface IFeedModelFactory<T>
    {
        Task<IEnumerable<T>> Create(IEnumerable<XElement> elements);
    }
}