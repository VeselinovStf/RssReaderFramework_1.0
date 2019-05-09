using RRF.EFModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRF.EFModels
{
    public class RssChannel : IEntity, IRssChanel, IModifiable, IDeletable
    {
        // IEntity
        public int Id { get; set; }

        // IRssChannel
        public string Name { get; set; }

        public string URL { get; set; }

        // RssSettins relations
        public RssSetting RssSeting { get; set; }

        // Client relation
        public string ClientId { get; set; }

        public Client Client { get; set; }

        // IModifiable , IDeletable
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
