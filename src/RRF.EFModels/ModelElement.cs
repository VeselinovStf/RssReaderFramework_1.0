using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class ModelElement : IEntity, IModifiable, IDeletable
    {
        public int Id { get; set; }
        public string BuildName { get; set; }
        public string Name { get; set; }
        public bool IsProcessed { get; set; }

        public int ModelRssSettingsId { get; set; }

        public RssSettings RssSetting { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}