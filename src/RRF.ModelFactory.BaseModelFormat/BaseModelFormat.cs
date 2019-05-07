using RRF.ModelFactory.BaseModelFormat.Abstract;
using RRF.ModelFactory.FormateElementsRepository.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Threading.Tasks;

namespace RRF.ModelFactory.BaseModelFormat
{
    /// <summary>
    /// Format all taken rss element text by specific formatting elements
    /// </summary>
    public class BaseModelFormat : IBaseModelFormat<IBaseModel>
    {
        
        private readonly IFormateElementsRepository formatElementsProvider;

        public BaseModelFormat(IFormateElementsRepository formatElementsProvider)
        {
            this.formatElementsProvider = formatElementsProvider;
        }
        public async Task<IBaseModel> Trim(IBaseModel model)
        {
            foreach (var trimElement in await this.formatElementsProvider.GetFormatElementsAsync())
            {
                model.Description = model.Description.Replace(trimElement, "").Trim();
                model.LinkToCurrentElement = model.LinkToCurrentElement.Replace(trimElement, "").Trim();
                model.Title = model.Title.Replace(trimElement, "").Trim();
               
            }

            return model;
        }
    }
}
