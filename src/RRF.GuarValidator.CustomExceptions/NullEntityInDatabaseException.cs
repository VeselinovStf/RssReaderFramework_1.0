using System;

namespace RRF.GuarValidator.CustomExceptions
{
    public class NullEntityInDatabaseException : Exception
    {
        public NullEntityInDatabaseException(string message) : base(message)
        {
        }
    }
}
