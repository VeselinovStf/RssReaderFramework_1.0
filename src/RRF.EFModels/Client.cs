﻿using RRF.EFModels.Abstract;
using RRF.Identity.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class Client : BaseIdentityModel, IClient<RssChannel>
    {
        public IEnumerable<RssChannel> Channels { get; set; }
        public Guid APIKey { get; set; }
    }
}