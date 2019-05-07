using System;
using System.Threading.Tasks;

namespace RRF.ModelFactory.BaseModelFormat.Abstract
{
    public interface IBaseModelFormat<T>
    {
        Task<T> Trim(T item);
    }
}
