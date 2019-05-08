using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModels;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class RssChanelConfig : IEFModelConfig<RssChannel>
    {
        public void Configure(EntityTypeBuilder<RssChannel> builder)
        {
            builder.HasMany(rc => rc.Settings)
                .WithOne(s => s.RssChannel)
                .HasForeignKey(s => s.RssChannelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}