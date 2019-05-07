using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RRF.ModelFactory.FormateElementsRepository.Abstract
{
    public interface IFormateElementsRepository
    {
        IList<string> GetFormatElements();
        Task<IList<string>> GetFormatElementsAsync();
    }
}
