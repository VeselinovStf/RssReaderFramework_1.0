using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class ImageFormat : IEntity, IModifiable, IDeletable
    {
        public int Id { get; set; }
        public IEnumerable<XElementModel> ImageSearchTag { get; set; }

        public int ImageRssSettingId { get; set; }

        public RssSettings ImageRssSetting { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}