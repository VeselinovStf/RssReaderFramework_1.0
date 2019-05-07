using System;
using System.Xml.Linq;

namespace RFF.ModelFactory.XElementInterpretator.Abstract
{
    public interface IXElementInterpretator<T>
    {
        T XElementToModel(XElement element);
    }
}
