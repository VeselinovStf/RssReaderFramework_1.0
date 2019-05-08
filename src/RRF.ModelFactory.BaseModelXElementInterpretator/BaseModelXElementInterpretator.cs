
using RFF.ModelFactory.XElementInterpretator.Abstract;
using RRF.EFService.ItemModelService.Abstract;
using RRF.ModelFactory.ModelBindDateTime.Abstract;
using RRF.ModelFactory.ModelBindImage.Abstract;
using RRF.ModelFactory.ModelBindString.Abstract;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using RRF.RRFDbContext;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RRF.ModelFactory.BaseModelXElementInterpretator
{
    public class BaseModelXElementInterpretator : IXElementInterpretator<IBaseModel>
    {
        private readonly IModelBindString xElementToString;
        private readonly IModelBindImage xElementToImageProps;
        private readonly IModelBindDateTime xElementToDateTime;
        private readonly IItemModelService itemModelService;

        public BaseModelXElementInterpretator(
            IModelBindString xElementToString,
            IModelBindImage xElementToImageProps,
            IModelBindDateTime xElementToDateTime,
            IItemModelService itemModelService
         )
        {
            this.xElementToString = xElementToString;
            this.xElementToImageProps = xElementToImageProps;
            this.xElementToDateTime = xElementToDateTime;
            this.itemModelService = itemModelService;
        }

       
        public async Task<IBaseModel> XElementToModel(XElement x, string userId)
        {
            
            try
            {
                var baseModel = await this.itemModelService.GetItem(userId);

                return new BaseModel()
                {

                    Title = this.xElementToString.GetElement(nameof(baseModel.Title).ToLower(), x),
                    LinkToCurrentElement = this.xElementToString.GetElement(nameof(baseModel.LinkToCurrentElement).ToLower(), x),
                    Description = this.xElementToString.GetElement(nameof(baseModel.Description).ToLower(), x),
                    PubDate = this.xElementToDateTime.Get(nameof(baseModel.PubDate).ToLower(), x),
                    ImageSRC = this.xElementToImageProps.GetFrom(nameof(baseModel.ImageSRC).ToLower(), x),

                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException("XElement to Model Exception");
            }
        }
    }
}
