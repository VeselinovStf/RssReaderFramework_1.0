using System;
using System.Xml.Linq;

namespace RRF.XDocumentWrapper.Abstract
{
    public interface IXDocumentWrapper
    {
        XDocument Parse(string RSSData);
    }
}