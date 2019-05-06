using System;
using System.Globalization;

namespace RRF.DateTimeWrapper.Abstract
{
    public interface IDateTimePars
    {
        DateTime Parse(string elementDateTime, string format, CultureInfo cultureInfo);
    }
}