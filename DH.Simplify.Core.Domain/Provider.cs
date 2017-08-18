using System;
using System.Collections.Generic;

namespace DH.Simplify.Core.Domain
{
    public partial class Provider
    {
        public Provider()
        {
            HelpDeskTickets = new HashSet<HelpDeskTicket>();
            TermsOfServices = new HashSet<TermsOfService>();
        }

        public int ProviderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BIO { get; set; }

        public string Speciality { get; set; }

        public byte[] Picture { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string LoginUserName { get; set; }

        public string LoginSourceId { get; set; }

        public string LoginSourceSystem { get; set; }

        public DateTime? LoginDeactivatedDate { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public Guid ProviderGuid { get; set; }

        public virtual ICollection<HelpDeskTicket> HelpDeskTickets { get; set; }

        public virtual ICollection<TermsOfService> TermsOfServices { get; set; }
    }
}
