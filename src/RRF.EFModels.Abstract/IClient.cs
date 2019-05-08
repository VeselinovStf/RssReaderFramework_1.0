using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels.Abstract
{
    public interface IClient<T> : IAPIKey
    {
        IEnumerable<T> Channels { get; set; }
    }
}
