using RRF.FeedModel.Abstract;
using RRF.FeedModelFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RRF.FeedModelFactory
{
    public class FeedModelFactory : IFeedModelFactory<IFeedNode>
    {
        //private readonly IModelFactoryValidator<BaseRssFeed> modelFactoryValidator;
        //private readonly ILogger<RssFeedModeFactory> logger;
        //private readonly IXelementModelInterpretator<BaseRssFeed> xElementToModel;
        //private readonly IModelFactoryModelFormat<BaseRssFeed> modelFormatter;

        //public FeedModelFactory(
        //    IModelFactoryValidator<BaseRssFeed> modelFactoryValidator,
        //    ILogger<RssFeedModeFactory> logger,
        //    IXelementModelInterpretator<BaseRssFeed> xElementToModel,
        //    IModelFactoryModelFormat<BaseRssFeed> modelFormatter)
        //{
        //    this.modelFactoryValidator = modelFactoryValidator;
        //    this.logger = logger;
        //    this.xElementToModel = xElementToModel;
        //    this.modelFormatter = modelFormatter;
        //}

        //public async Task<IEnumerable<T>> Create(IEnumerable<XElement> elements)
        //{
        //    IList<T> RSSFeedData = new List<T>();
        //    foreach (var e in elements)
        //    {
        //        try
        //        {
        //            var modelFromXElement = this.xElementToModel.XElementToModel(e);

        //            RSSFeedData.Add(
        //                this.modelFactoryValidator.ValidateRssFeedModel(
        //                    await this.modelFormatter.Trim(modelFromXElement)
        //                    )
        //               );
        //        }
        //        catch (Exception ex)
        //        {
        //            this.logger.LogWarning(ex.Message);
        //        }
        //    }

        //    return RSSFeedData;
        //}
        public async Task<IEnumerable<IFeedNode>> Create(IEnumerable<XElement> elements)
        {
            throw new NotImplementedException();
        }
    }
}