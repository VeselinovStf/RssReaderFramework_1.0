using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class ImageElement : IEntity, IElement, IModifiable, IDeletable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ElementSubName { get; set; }

        // RssSetting relation - Image Format name elements relation
        public int? RssSettingImageFormatElement_Id { get; set; }

        public RssSetting RssSettingImageFormatElement { get; set; }

        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
