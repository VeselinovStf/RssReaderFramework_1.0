using RRF.EFModels.Abstract;
using RRF.Identity.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace RRF.EFModels
{
    public class RssChannel : IEntity, IModifiable, IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public string ClientId { get; set; }

        public Client Client { get; set; }

        public IEnumerable<RssSettings> Settings { get; set; }
        public Guid UserId { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}