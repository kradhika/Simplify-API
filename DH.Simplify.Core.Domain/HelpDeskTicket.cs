using System;

namespace DH.Simplify.Core.Domain
{
    public partial class HelpDeskTicket
    {
        public int HelpDeskTicketId { get; set; }

        public Guid HelpDeskTicketGuid { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ProviderId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int StatusId { get; set; }

        public virtual HelpDeskAttachnment HelpDeskAttachnment { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Status Status { get; set; }
    }
}
