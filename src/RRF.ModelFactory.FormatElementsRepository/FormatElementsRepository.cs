
using RRF.EFService.FormatElementsService.Abstract;
using RRF.ModelFactory.FormateElementsRepository.Abstract;
using RRF.RRFDbContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.ModelFactory.FormatElementsRepository
{
    public class FormatElementsRepository : IFormateElementsRepository
    {
        private readonly IFormatElementsService formatElementsService;

        public FormatElementsRepository(IFormatElementsService formatElementsService)
        {
            this.formatElementsService = formatElementsService;
        }

        public IList<string> GetFormatElements()
        {
            throw new NotImplementedException();
        }

        //private readonly IFakeContext context;

        //public FormatElementsRepository(IFakeContext context)
        //{
        //    this.context = context;
        //}

        //public IList<string> GetFormatElements()
        //{
        //    return this.context.FormatElements;
        //}

     
        public async Task<IList<string>> GetFormatElementsAsync(string userId)
        {
            var elements = await this.formatElementsService.GetFormatElementsAsync(userId);

            return elements;
        }
    }
}
