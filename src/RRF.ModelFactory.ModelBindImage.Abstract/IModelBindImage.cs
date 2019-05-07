using System;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindImage.Abstract
{
    public interface IModelBindImage
    {
        string GetFrom(string elementName, XElement xElement);
    }
}
