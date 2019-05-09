using Microsoft.Extensions.Logging;
using RFF.ModelFactory.XElementInterpretator.Abstract;
using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
using RRF.FeedModelFactoryValidator.Abstract;
using RRF.GuarValidator.CustomExceptions;
using RRF.ModelFactory.BaseModelFormat.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RRF.FeedModelFactory
{
    public class FeedModelFactory : IFeedModelFactory<IBaseModel>
    {
        private readonly IFeedModelFactoryValidator<IBaseModel> modelFactoryValidator;
        private readonly ILogger<FeedModelFactory> logger;
        private readonly IXElementInterpretator<IBaseModel> xElementToModel;
        private readonly IBaseModelFormat<IBaseModel> modelFormatter;

        public FeedModelFactory(
            IFeedModelFactoryValidator<IBaseModel> modelFactoryValidator,
            ILogger<FeedModelFactory> logger,
            IXElementInterpretator<IBaseModel> xElementToModel,
            IBaseModelFormat<IBaseModel> modelFormatter)
        {
            this.modelFactoryValidator = modelFactoryValidator;
            this.logger = logger;
            this.xElementToModel = xElementToModel;
            this.modelFormatter = modelFormatter;
        }

        public async Task<IEnumerable<IBaseModel>> Create(IEnumerable<XElement> elements, string userId)
        {
            IList<IBaseModel> RSSFeedData = new List<IBaseModel>();
            foreach (var e in elements)
            {
                try
                {              
                    var modelFromXElement = await this.xElementToModel.XElementToModel(e, userId);

                    RSSFeedData.Add(
                        this.modelFactoryValidator.ValidateRssFeedModel(
                            await this.modelFormatter.Trim(modelFromXElement)
                            )
                       );
                }
                catch (Exception ex)
                {
                    this.logger.LogWarning(ex.Message);

                    throw new ArgumentException(ex.Message);
                }
            }

            return RSSFeedData;
        }
    
    }
}