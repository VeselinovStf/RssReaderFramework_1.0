using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class RssSettings : IEntity, IModifiable, IDeletable
    {
        public int Id { get; set; }

        public XElementModel MainElement { get; set; }

        public ImageFormat ImageFormats { get; set; }

        public int RssChannelId { get; set; }
        public RssChannel RssChannel { get; set; }
        public IEnumerable<ModelElement> ModelElements { get; set; }
        public Guid UserId { get; set; }

        public ItemModel ItemModel { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}