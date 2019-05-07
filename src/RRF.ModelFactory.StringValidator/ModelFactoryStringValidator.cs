using RRF.ModelFactory.StringValidator.Abstract;
using System;

namespace RRF.ModelFactory.StringValidator
{
    public class ModelFactoryStringValidator : IModelFactoryStringValidator
    {
        public string StringIsNullOrWhiteSpace(string str, string modelFieldName)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException($"Ivalid Rss Model Parameter : {modelFieldName}!");
            }

            return str;
        }
    }
}
