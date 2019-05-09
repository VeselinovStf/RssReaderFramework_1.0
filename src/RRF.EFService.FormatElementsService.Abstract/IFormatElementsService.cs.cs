using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.EFService.FormatElementsService.Abstract
{
    public interface IFormatElementsService
    {
        Task<IList<string>> GetFormatElementsAsync(string userId);
    }
}
