using RRF.BaseModelAccess.Abstract;
using RRF.BaseModelFeed.Abstract;
using RRF.BaseModelRepository.Abstract;
using RRF.FeedModel.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.BaseModelAccess
{
    /// <summary>
    /// RRF Access point for IFeedNode
    /// </summary>
    public class BaseModelAccess : IBaseModelAccess
    {
        private readonly IBaseModelRepository baseModelRepo;

        public BaseModelAccess(IBaseModelRepository baseModelRepo)
        {
            this.baseModelRepo = baseModelRepo;
        }

        public async Task<IBaseModelFeed> GetFeed(string userId)
        {
            return new BaseModelFeed.BaseModelFeed()
            {
                Feed = await this.baseModelRepo.GetListedFeed(userId)
            };
        }
    }
}
