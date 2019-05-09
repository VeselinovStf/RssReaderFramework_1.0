using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.EFService.ItemModelService.Abstract;
using RRF.GuardValidator;
using RRF.Model.GeneratedModels;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using RRF.RRFDbContext;
using System;
using System.Threading.Tasks;

namespace RRF.EFService.ItemModelService
{
    public class ItemModelService : IItemModelService
    {
        private readonly IEFRepository<ModelElement> itemModelRepository;

        public ItemModelService(IEFRepository<ModelElement> itemModelRepository)
        {
            this.itemModelRepository = itemModelRepository;
        }
        public async Task<BaseGeneratedModel> GetItem(string userId)
        {
            var call = await this.itemModelRepository.GetSingleAsync(userId);

            Validator.ItemModelObjectIsNull(call);

            return new BaseGeneratedModel()
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
