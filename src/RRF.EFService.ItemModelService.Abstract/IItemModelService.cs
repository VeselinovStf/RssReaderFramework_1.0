using RRF.Model.GeneratedModels;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.ItemModelService.Abstract
{
    public interface IItemModelService
    {
        Task<BaseGeneratedModel> GetItem(string userId);
    }
}
