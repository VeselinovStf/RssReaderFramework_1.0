using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class XElementModel : IEntity, IModifiable, IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RssElementsSettingId { get; set; }
        public RssSettings RssElementsSetting { get; set; }

        public int ImageFormatId { get; set; }

        public ImageFormat ImageFormat { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}