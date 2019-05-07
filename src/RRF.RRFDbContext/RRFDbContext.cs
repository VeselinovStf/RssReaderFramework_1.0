using Microsoft.EntityFrameworkCore;
using RRF.EFModels.BaseModel;
using RRF.EFModels.FeedNodeModel;
using RRF.Model.ImageInterpretatorElement;
using RRF.Models.FormatElement;
using System;

namespace RRF.RRFDbContext
{
    public class RRFDbContext : DbContext
    {
        public DbSet<EFBaseModel> BaseModel { get; set; }
        public DbSet<FormatElement> FormatElements { get; set; }
        public DbSet<ImageInterpretatorElement> ImageInterpretatorElement { get; set; }      
        public DbSet<FeedNodeModel> Feeds { get; set; }

        protected RRFDbContext(DbContextOptions<RRFDbContext> option) : base(option)
        {

        }
    }
}
