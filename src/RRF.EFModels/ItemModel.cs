using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class ItemModel : IEntity, IModifiable, IDeletable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkToCurrentElement { get; set; }
        public string ImageSRC { get; set; }
        public DateTime PubDate { get; set; }
        public int Id { get; set; }

        public int ItemRssSettingId { get; set; }

        public RssSettings ItemRssSetting { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}