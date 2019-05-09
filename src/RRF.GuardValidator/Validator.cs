using RRF.EFModels;
using RRF.GuarValidator.CustomExceptions;
using System;
using System.Collections.Generic;

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

        public static void ObjectIsNull(object obj, string message)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void RssSettingsObjectIsNull(RssSetting call)
        {
            if (call == null)
            {
                throw new NullEntityInDatabaseException("No RssSettings in Db");
            }
        }

        public static void ItemModelObjectIsNull(ModelElement call)
        {
            if (call == null)
            {
                throw new NullEntityInDatabaseException("No ItemModelElement in Db");
            }
        }

        public static void XElementObjectIsNull(IEnumerable<XElementModel> elements)
        {
            if (elements == null)
            {
                throw new NullEntityInDatabaseException("No XElements Formatters in Db");
            }
        }

        public static void RssCannelObjectIsNull(IEnumerable<RssChannel> call)
        {
            if (call == null)
            {
                throw new NullEntityInDatabaseException("No RssChannels in Db");
            }
        }
    }
}
