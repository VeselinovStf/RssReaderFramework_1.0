﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModels;
using RRF.EFModels.Abstract;
using RRF.EFModelsConfig.Abstract;
using RRF.Identity.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class ClientConfig : IEFModelConfig<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey(i => new { i.UserId, i.RoleId });
        }
    }
}