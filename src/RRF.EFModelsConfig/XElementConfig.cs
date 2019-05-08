using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RRF.EFModels;
using RRF.EFModelsConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModelsConfig
{
    public class XElementConfig //: IEFModelConfig<XElementModel>
    {
        //public void Configure(EntityTypeBuilder<XElementModel> builder)
        //{
        //    builder.HasOne(e => e.RssElementsSetting)
        //        .WithOne(s => s.MainElement)
        //        .HasForeignKey<RssSettings>(k => k.MainElementId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}