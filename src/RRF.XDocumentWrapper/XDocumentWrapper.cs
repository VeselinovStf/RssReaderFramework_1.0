using RRF.XDocumentWrapper.Abstract;
using System;
using System.Xml.Linq;

namespace RRF.XDocumentWrapper
{
    public class XDocumentWrapper : IXDocumentWrapper
    {
        public XDocument Parse(string RSSData)
        {
            return XDocument.Parse(RSSData);
        }
    }
}