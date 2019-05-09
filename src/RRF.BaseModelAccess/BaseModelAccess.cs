using RRF.BaseModelAccess.Abstract;
using RRF.BaseModelFeed.Abstract;
using RRF.BaseModelRepository.Abstract;
using RRF.FeedModel.Abstract;
using RRF.GuarValidator.CustomExceptions;
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
            try
            {
                return new BaseModelFeed.BaseModelFeed()
                {
                    Feed = await this.baseModelRepo.GetListedFeed(userId)
                };
            }
            catch (NullEntityInDatabaseException ex)
            {

                throw new ArgumentException(ex.Message);
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
           

        }
    }
}
