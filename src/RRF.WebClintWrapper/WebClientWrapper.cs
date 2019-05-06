using RRF.WebClientWrapper.Abstract;
using System;
using System.Net;

namespace RRF.WebClintWrapper
{
    public class WebClientWrapper : IWebClientWrapper
    {
        private readonly WebClient webClient;

        public WebClientWrapper(WebClient webClient)
        {
            this.webClient = webClient;
        }

        public string DownloadString(string RSSURL)
        {
            return this.webClient.DownloadString(RSSURL);
        }
    }
}