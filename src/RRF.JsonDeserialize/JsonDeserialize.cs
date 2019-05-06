using Newtonsoft.Json;
using RRF.JsonDeserialize.Abstract;
using System;

namespace RRF.JsonDeserialize
{
    public class JsonDeserialize<T> : IJsonDeserialize<T>
    {
        public T Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}