using System;
using System.Collections.Generic;

namespace FakeEFContext
{
    public interface IFakeContext
    {
        IList<string> FormatElements { get; set; }
    }
}
