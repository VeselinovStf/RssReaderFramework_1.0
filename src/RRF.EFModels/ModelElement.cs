using RRF.EFModels.Abstract;
using RRF.Models.BaseModel.Abstract;
using System;

namespace RRF.EFModels
{
    public class ModelElement : IEntity, IModifiable, IDeletable
    {
        // IEntity
        public int Id { get; set; }
        //IBaseModel
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkToCurrentElement { get; set; }
        public string ImageSRC { get; set; }
        public string PubDate { get; set; }

        // RssSetting relation - RssDisplay model relation
        public int RssSettingDisplayModelElementId { get; set; }

        public RssSetting RssSettingDisplayModelElement { get; set; }

        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
     
    }
}