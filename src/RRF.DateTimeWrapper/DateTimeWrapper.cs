using RRF.DateTimeWrapper.Abstract;
using System;
using System.Globalization;

namespace RRF.DateTimeWrapper
{
    public class DateTimeWrapper : IDateTimePars
    {
        public DateTime Parse(string elementDateTime, string format, CultureInfo cultureInfo)
        {
            return DateTime.ParseExact(elementDateTime, format, cultureInfo);
        }
    }
}