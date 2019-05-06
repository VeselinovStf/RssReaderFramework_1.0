using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.Models.BaseModel.Abstract
{
    public interface ILinkElement
    {
        string LinkToCurrentElement { get; set; }
    }
}