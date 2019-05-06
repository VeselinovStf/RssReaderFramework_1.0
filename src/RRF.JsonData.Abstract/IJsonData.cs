using System;

namespace RRF.JsonData.Abstract
{
    public interface IJsonData<T>
    {
        T GetContent();
    }
}