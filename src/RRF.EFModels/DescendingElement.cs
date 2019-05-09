using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class DescendingElement : IEntity, IElement, IModifiable, IDeletable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Relations
        // RssSetting relation - DescendantElement
        public int? RssSettingDescendantElement_Id { get; set; }

        public RssSetting RssSettingDescendantElement { get; set; }

        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
