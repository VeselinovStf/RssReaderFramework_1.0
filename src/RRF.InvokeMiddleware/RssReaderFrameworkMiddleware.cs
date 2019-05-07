using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace RRF.InvokeMiddleware
{
    public class RssReaderFrameworkMiddleware
    {
        private readonly RequestDelegate next;

        public RssReaderFrameworkMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //Do extra job here


            await this.next(context);
        }
    }
}
