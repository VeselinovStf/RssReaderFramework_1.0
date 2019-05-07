
using RRF.ModelFactory.ModelBindImage.Abstract;
using RRF.RRFDbContext;
using System;
using System.Text;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindImage
{
    public class ModelBindImage : IModelBindImage
    {
        private readonly RRFDbContext.RRFDbContext context;

        public ModelBindImage(RRFDbContext.RRFDbContext context)
        {
            this.context = context;
        }

        //TODO: Extend this implementation
        public string GetFrom(string elementName, XElement xElement)
        {
            try
            {
                var test = xElement.Element("enclosure").Attribute("url");

                if (test != null)
                {
                    return test.Value;
                }
            }
            catch (Exception)
            {
                //This case is for second
                var t2 = xElement.Element("description").Value;
                var imgStartIndex = t2.IndexOf("src=\"") + 5;

                StringBuilder resultUrl = new StringBuilder();
                for (int i = imgStartIndex; i < t2.Length; i++)
                {
                    if (t2[i] == '"')
                    {
                        break;
                    }
                    else
                    {
                        resultUrl.Append(t2[i]);
                    }
                }

                return resultUrl.ToString();
            }

            throw new ArgumentException("Boom...");
        }
    }
}
