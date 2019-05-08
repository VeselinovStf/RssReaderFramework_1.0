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
    public class RssSettingsConfig : IEFModelConfig<RssSettings>
    {
        public void Configure(EntityTypeBuilder<RssSettings> builder)
        {
            builder.HasMany(me => me.ModelElements)
                .WithOne(e => e.RssSetting)
                .HasForeignKey(me => me.ModelRssSettingsId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.MainElement)
                .WithOne(s => s.RssElementsSetting)
                .HasForeignKey<XElementModel>(k => k.RssElementsSettingId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(me => (ImageFormat)me.ImageFormats)
                .WithOne(e => e.ImageRssSetting)
                .HasForeignKey<ImageFormat>(k => k.ImageRssSettingId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => (ItemModel)i.ItemModel)
                .WithOne(e => e.ItemRssSetting)
                .HasForeignKey<ItemModel>(k => k.ItemRssSettingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}