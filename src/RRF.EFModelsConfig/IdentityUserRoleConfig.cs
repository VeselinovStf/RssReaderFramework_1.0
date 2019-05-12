using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class IdentityUserRoleConfig : IEFModelConfig<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey(i => new { i.RoleId, i.UserId });
        }
    }
}