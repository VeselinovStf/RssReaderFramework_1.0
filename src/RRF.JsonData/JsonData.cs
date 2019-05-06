using RFF.JsonFunction.Abstract;
using RRF.JsonData.Abstract;
using System;

namespace RRF.JsonData
{
    public class JsonData<T> : IJsonData<T>
    {
        private readonly IJsonGetFunction<T> jsonGetFunction;

        public JsonData(IJsonGetFunction<T> jsonGetFunction)
        {
            this.jsonGetFunction = jsonGetFunction;
        }

        public T GetContent()
        {
            return this.jsonGetFunction.Get();
        }
    }
}