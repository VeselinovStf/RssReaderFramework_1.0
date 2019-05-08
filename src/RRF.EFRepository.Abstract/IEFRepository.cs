using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.EFRepository.Abstract
{
    public interface IEFRepository<T>
    {
        Task<IEnumerable<T>> GetSetAsync();

        Task<T> GetSingleAsync(string rssSetting);
    }
}