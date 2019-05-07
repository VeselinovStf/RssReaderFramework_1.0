using RRF.FeedModel.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.BaseModelRepository.Abstract
{
    public interface IBaseModelRepository
    {
        Task<IEnumerable<IEnumerable<IBaseModel>>> GetListedFeed();
    }
}
