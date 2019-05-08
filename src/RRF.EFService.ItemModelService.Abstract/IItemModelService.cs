using RRF.Models.BaseModel.Abstract;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.ItemModelService.Abstract
{
    public interface IItemModelService
    {
        Task<IBaseModel> GetItem(string userId);
    }
}
