using System;

namespace RRF.JsonWrapper.Abstract
{
    public interface IJsonWrapper<T>
    {
        string SerializeObject(T model);
    }
}
