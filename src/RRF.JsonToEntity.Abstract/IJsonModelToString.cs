using System;
using System.Collections.Generic;

namespace RRF.JsonToEntity.Abstract
{
    public interface IJsonModelToString<T>
    {
        IList<string> ModelToString(T jsonConvertedModel);
    }
}