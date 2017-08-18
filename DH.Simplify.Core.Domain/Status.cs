using System.Collections.Generic;

namespace DH.Simplify.Core.Domain
{
    public partial class Status
    {
        public Status()
        {
            HelpDeskTickets = new HashSet<HelpDeskTicket>();
        }

        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

        public virtual ICollection<HelpDeskTicket> HelpDeskTickets { get; set; }
    }
}
