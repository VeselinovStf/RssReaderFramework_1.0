using System;

namespace RRF.FeedModelFactoryValidator.Abstract
{
    public interface IFeedModelFactoryValidator<T>
    {
        T ValidateRssFeedModel(T model);
    }
}
