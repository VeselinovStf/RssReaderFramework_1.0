using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModels;
using RRF.EFModels.Abstract;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class RssSettingsConfig : IEFModelConfig<RssSetting>
    {
        public void Configure(EntityTypeBuilder<RssSetting> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder.HasOne(x => x.DescendantElement)
                .WithOne(s => s.RssSettingDescendantElement)
                .HasForeignKey<DescendingElement>(x => x.RssSettingDescendantElement_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.RssModelElements)
                .WithOne(m => m.RssSettingDisplayModelElement)
                .HasForeignKey<ModelElement>(m => m.RssSettingDisplayModelElementId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.RssImageFormatElements)
               .WithOne(x => x.RssSettingImageFormatElement)
               .HasForeignKey(x => x.RssSettingImageFormatElement_Id)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.RssFormatElements)
               .WithOne(x => x.RssSettingFormatElements)
               .HasForeignKey(x => x.RssSettingFormatElements_Id)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}