using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindString.Abstract
{
    public interface IModelBindString
    {
        string GetElement(string elementName, XElement xElement);
    }
}
