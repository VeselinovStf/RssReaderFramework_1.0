using System;

namespace RRF.Core.Utility.Json.Repository.Abstract
{
    public interface IJsonRepository<T>
    {
        T GetContent(string fileName);
    }
}