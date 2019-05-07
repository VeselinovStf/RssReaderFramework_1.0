using Microsoft.Extensions.DependencyInjection;
using System;

namespace RRF.Core.Container
{
    public class RssReaderFrameworkConfigure
    {
        public static void GoRssReaderFrameworkToWork(IServiceCollection service, string databaseName)
        {
            RegisterRssReaderFrameworkServices(service);
            RunRssReaderFrameworkDatabase(databaseName);
        }

        private static void RunRssReaderFrameworkDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        private static void RegisterRssReaderFrameworkServices(IServiceCollection service)
        {

        }
    }
}
