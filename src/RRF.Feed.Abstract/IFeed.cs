using System;
using System.Collections;
using System.Collections.Generic;

namespace RRF.Feed.Abstract
{
    public interface IFeed<T>
    {
        IEnumerable<T> GetAll();
    }
}