using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.EFService.ItemModelService.Abstract;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using RRF.RRFDbContext;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.ItemModelService
{
    public class ItemModelService : IItemModelService
    {
        private readonly IEFRepository<ItemModel> itemModelRepository;

        public ItemModelService(IEFRepository<ItemModel> itemModelRepository)
        {
            this.itemModelRepository = itemModelRepository;
        }
        public async Task<IBaseModel> GetItem(string userId)
        {
            var call = await this.itemModelRepository.GetSingleAsync(userId);

            return new BaseModel()
            {
                Description = call.Description,
                ImageSRC = call.ImageSRC,
                LinkToCurrentElement = call.LinkToCurrentElement,
                PubDate = call.PubDate,
                Title = call.Title
            };
        }
    }
}
