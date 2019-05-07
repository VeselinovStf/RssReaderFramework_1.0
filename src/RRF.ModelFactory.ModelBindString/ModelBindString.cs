using RRF.ModelFactory.ModelBindString.Abstract;
using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindString
{
    public class ModelBindString : IModelBindString
    {
        public string GetElement(string elementName, XElement xElement)
        {
            return (string)xElement.Element(elementName);
        }
    }
}
