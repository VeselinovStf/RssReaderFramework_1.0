using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RFF.ModelFactory.XElementInterpretator.Abstract
{
    public interface IXElementInterpretator<T>
    {
        Task<T> XElementToModel(XElement element, string userId);
    }
}
