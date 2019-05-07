using RRF.FeedModel.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Collections.Generic;

namespace FakeEFContext
{
    public interface IFakeContext
    {
        IList<string> FormatElements { get; set; }
        IList<string> ImageIterpretatorElements { get; set; }
        IBaseModel BaseModel { get; set; }
        IEnumerable<IFeedNode> Feeds { get; set; }
    }
}
