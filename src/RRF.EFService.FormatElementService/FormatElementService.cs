using Microsoft.EntityFrameworkCore;
using RRF.EFModels;
using RRF.EFRepository.Abstract;
using RRF.EFService.FormatElementsService.Abstract;
using RRF.GuardValidator;
using RRF.RRFDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.EFService.FormatElementService
{
    public class FormatElementService : IFormatElementsService
    {
        private readonly IEFRepository<XElementModel> formatElementRepository;

        public FormatElementService(IEFRepository<XElementModel> formatElementRepository)
        {
            this.formatElementRepository = formatElementRepository;
        }
        public async Task<IList<string>> GetFormatElementsAsync(string userId)
        {
            var call = await this.formatElementRepository.GetSetAsync(userId);

            Validator.XElementObjectIsNull(call);
         
            var result = new List<string>();

            foreach (var xElement in call)
            {
                result.Add(xElement.Name);
            }

            return result;
             
        }
    }
}
