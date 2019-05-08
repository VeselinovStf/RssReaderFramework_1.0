using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModels;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class ImageFormatConfig : IEFModelConfig<ImageFormat>
    {
        public void Configure(EntityTypeBuilder<ImageFormat> builder)
        {
            builder.HasMany(xe => xe.ImageSearchTag)
               .WithOne(e => (ImageFormat)e.ImageFormat)
               .HasForeignKey(me => me.ImageFormatId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}