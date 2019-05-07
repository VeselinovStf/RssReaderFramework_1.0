using RRF.BaseModelFeed.Abstract;
using RRF.FeedModel.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.BaseModelAccess.Abstract
{
    public interface IBaseModelAccess
    {
        Task<IBaseModelFeed> GetFeed();
    }
}
