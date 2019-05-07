using System;

namespace RRF.ModelFactory.StringValidator.Abstract
{
    public interface IModelFactoryStringValidator
    {
        string StringIsNullOrWhiteSpace(string str, string modelFieldName);
    }
}
