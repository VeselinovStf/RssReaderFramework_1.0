using RRF.FeedModelFactoryValidator.Abstract;
using RRF.ModelFactory.StringValidator.Abstract;
using RRF.Models.BaseModel;
using RRF.Models.BaseModel.Abstract;
using System;

namespace RRF.FeedModelFactoryValidator
{
    /// <summary>
    /// Inject all types of validators
    /// </summary>
    public class FeedModelFactoryValidator : IFeedModelFactoryValidator<IBaseModel>
    {
        private readonly IModelFactoryStringValidator stringValidator;

        public FeedModelFactoryValidator(IModelFactoryStringValidator stringValidator)
        {
            this.stringValidator = stringValidator;
        }

       
        /// <summary>
        /// Validate every model field
        /// </summary>
        /// <param name="model">Model to validate</param>
        /// <returns></returns>
        public IBaseModel ValidateRssFeedModel(IBaseModel model)
        {
            try
            {
                return new BaseModel()
                {
                    Title = this.stringValidator.StringIsNullOrWhiteSpace(model.Title, nameof(model.Title)),
                    Description = this.stringValidator.StringIsNullOrWhiteSpace(model.Title, nameof(model.Description)),
                    LinkToCurrentElement = this.stringValidator.StringIsNullOrWhiteSpace(model.Title, nameof(model.LinkToCurrentElement))
                };
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
    }
}
