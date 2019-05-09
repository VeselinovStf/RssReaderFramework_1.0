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
    public class ClientConfig : IEFModelConfig<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasMany(c => c.Channels)
                .WithOne(cl => cl.Client)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}