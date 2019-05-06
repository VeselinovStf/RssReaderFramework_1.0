using RRF.Models.BaseModel.Abstract;
using System;

namespace RRF.Models.BaseModel
{
    /// <summary>
    /// Base Model for getting all props from RSS Feed
    /// </summary>
    public class BaseModel : IHeaderInfoElement, ILinkElement, IImageElement, IDateTimeElement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkToCurrentElement { get; set; }
        public string ImageSRC { get; set; }
        public DateTime PubDate { get; set; }
    }
}