using System;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.EFRepository.Abstract
{
    public interface IEFRepository<T>
    {
        Task<IQueryable<T>> GetSetAsync();
        Task<T> GetSingleAsync(string rssSetting);
    }
}
