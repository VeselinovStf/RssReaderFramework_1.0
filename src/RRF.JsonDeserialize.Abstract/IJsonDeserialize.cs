using System;

namespace RRF.JsonDeserialize.Abstract
{
    public interface IJsonDeserialize<T>
    {
        T Deserialize(string value);
    }
}