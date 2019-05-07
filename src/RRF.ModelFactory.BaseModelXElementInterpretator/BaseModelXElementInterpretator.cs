using FakeEFContext;
using RFF.ModelFactory.XElementInterpretator.Abstract;
using RRF.ModelFactory.ModelBindDateTime.Abstract;
using RRF.ModelFactory.ModelBindImage.Abstract;
using RRF.ModelFactory.ModelBindString.Abstract;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.BaseModelXElementInterpretator
{
    public class BaseModelXElementInterpretator : IXElementInterpretator<IBaseModel>
    {
        private readonly IModelBindString xElementToString;
        private readonly IModelBindImage xElementToImageProps;
        private readonly IModelBindDateTime xElementToDateTime;
        private readonly IFakeContext context;

        public BaseModelXElementInterpretator(
            IModelBindString xElementToString,
            IModelBindImage xElementToImageProps,
            IModelBindDateTime xElementToDateTime,
            IFakeContext context)
        {
            this.xElementToString = xElementToString;
            this.xElementToImageProps = xElementToImageProps;
            this.xElementToDateTime = xElementToDateTime;
            this.context = context;
        }

        //TODO: get elements name from db
        public IBaseModel XElementToModel(XElement x)
        {
            var baseModel = this.context.BaseModel;

            try
            {
                return new BaseModel()
                {
                    // TODO: link propertyes names for json config , so property name can be changed based pn user requirements
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
