using RRF.BaseModelFeed.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;
using System.Collections.Generic;

namespace RRF.BaseModelFeed
{
    public class BaseModelFeed : IBaseModelFeed
    {
        public IEnumerable<IEnumerable<IBaseModel>> Feed { get; set; }
    }
}
