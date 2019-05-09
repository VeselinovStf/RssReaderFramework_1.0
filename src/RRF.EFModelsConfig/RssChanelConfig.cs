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
            builder
                .HasKey(c => c.Id);

            builder.HasOne(s => s.RssSeting)
                .WithOne(s => s.RssChannel)
                .HasForeignKey<RssSetting>(s => s.RssChanel_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}