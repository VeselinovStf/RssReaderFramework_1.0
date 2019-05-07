using RFF.ModelFactory.XElementInterpretator.Abstract;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.BaseModelXElementInterpretator
{
    public class BaseModelXElementInterpretator : IXElementInterpretator<IBaseModel>
    {
        private readonly IXElementToString xelementToStringConvertor;
        private readonly IXElementToImageProps xelementToImageProps;
        private readonly IXelementToDateTime xElementToDateTime;

        public BaseModelXElementInterpretator(
            IXElementToString xelementToStringConvertor,
            IXElementToImageProps xelementToImageProps,
            IXelementToDateTime xElementToDateTime)
        {
            this.xelementToStringConvertor = xelementToStringConvertor;
            this.xelementToImageProps = xelementToImageProps;
            this.xElementToDateTime = xElementToDateTime;
        }

        public IBaseModel XElementToModel(XElement element)
        {
            try
            {
                return new BaseModel()
                {
                    // TODO: link propertyes names for json config , so property name can be changed based pn user requirements
                    Title = this.xelementToStringConvertor.Get("title", x),
                    LinkToCurrentElement = this.xelementToStringConvertor.Get("link", x),
                    Description = this.xelementToStringConvertor.Get("description", x),
                    PubDate = this.xElementToDateTime.Get("pubDate", x),
                    ImageSRC = this.xelementToImageProps.GetFrom("src", x),
                    
                };
            }
            catch (Exception ex)
            {
                throw new ArgumentException("XElement to Model Exception");
            }
        }
    }
}
