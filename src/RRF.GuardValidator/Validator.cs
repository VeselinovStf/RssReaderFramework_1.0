using System;

namespace RRF.GuardValidator
{
    public class Validator
    {
        public static void StringIsNullOrEmpty(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("String parameter is null or empty or white space!");
            }
        }
    }
}
