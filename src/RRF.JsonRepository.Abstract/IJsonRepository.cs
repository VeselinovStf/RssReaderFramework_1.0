using System;

namespace RRF.JsonRepository.Abstract
{
    public interface IJsonRepository<T>
    {
        T Get();
    }
}