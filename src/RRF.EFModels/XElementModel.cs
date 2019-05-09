using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class XElementModel : IEntity, IXElementModel,  IModifiable, IDeletable
    {
        // IEntity
        public int Id { get; set; }

        // IXElementModel
        public string Name { get; set; }

        public string UseName { get; set; }    

        // RssSetting relation - FormatElements relation
        public int? RssSettingFormatElements_Id { get; set; }

        public RssSetting RssSettingFormatElements { get; set; }

        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
