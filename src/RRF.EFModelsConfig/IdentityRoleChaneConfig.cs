using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class IdentityRoleChaneConfig : IEFModelConfig<IdentityRoleClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> builder)
        {
            builder.HasKey(i => new { i.Id, i.RoleId });
        }
    }
}