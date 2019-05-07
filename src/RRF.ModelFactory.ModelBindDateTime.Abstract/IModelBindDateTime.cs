using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindDateTime.Abstract
{
    public interface IModelBindDateTime
    {
        DateTime Get(string elementName, XElement xElement);
    }
}
