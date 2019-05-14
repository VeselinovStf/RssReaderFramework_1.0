using Newtonsoft.Json;
using RRF.JsonWrapper.Abstract;
using System;

namespace RRF.JsonSerializeWrapper
{
    public class JsonSerializeWrapper<T> : IJsonWrapper<T>
    {
        public string SerializeObject(T model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
