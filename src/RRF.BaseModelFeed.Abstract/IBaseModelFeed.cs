using RRF.Models.BaseModel.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RRF.BaseModelFeed.Abstract
{
    public interface IBaseModelFeed
    {
        IEnumerable<IEnumerable<IBaseModel>> Feed { get; set; }
    }
}
