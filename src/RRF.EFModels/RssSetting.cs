using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class RssSetting : IEntity, IModifiable, IDeletable
    {
        // IEntity
        public int Id { get; set; }

        // RssChannel relation
        public int? RssChanel_Id { get; set; }

        public RssChannel RssChannel { get; set; }

        // Descendant Element Relation
        public DescendingElement DescendantElement { get; set; }

        // RssModelElement model relation
        public ModelElement RssModelElements { get; set; }

        // Image Format name elements relation
        public IEnumerable<ImageElement> RssImageFormatElements { get; set; }

        // FormatElements relation
        public IEnumerable<XElementModel> RssFormatElements{ get; set; }

        // Client speed-found
        public string ClientId { get; set; }


        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
