using RRF.EFModels;
using RRF.FeedModel.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.EFService.RssChanelService.Abstract
{
    public interface IRssChanelService
    {
        Task<IEnumerable<RssChannel>> GetAll(string userId);
    }
}
