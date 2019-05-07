using RRF.DateTimeWrapper.Abstract;
using RRF.ModelFactory.ModelBindDateTime.Abstract;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace RRF.ModelFactory.ModelBindDateTime
{
    public class ModelBindDateTime : IModelBindDateTime
    {
        private readonly IDateTimePars dateTimeParser;

        public ModelBindDateTime(IDateTimePars dateTimeParser)
        {
            this.dateTimeParser = dateTimeParser;
        }
        public DateTime Get(string elementName, XElement xElement)
        {
            var elementDateTime = xElement.Element(elementName).Value;

            try
            {
                //TODO : Remove hard Coded format for dateTime
                var convertedToDateTime = this.dateTimeParser.Parse(elementDateTime, "ddd, dd MMM yyyy HH:mm:ss zzz", CultureInfo.InvariantCulture);

                return convertedToDateTime;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't parse DateTime");
            }
        }
    }
}
