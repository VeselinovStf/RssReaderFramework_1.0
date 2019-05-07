using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.InvokeMiddleware
{
    public static class RssReaderFrameworkMiddlewareExtension
    {
        public static IApplicationBuilder UseRssReaderFramework(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RssReaderFrameworkMiddleware>();
        }
    }
}
