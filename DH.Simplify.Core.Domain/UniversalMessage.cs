using System;

namespace DH.Simplify.Core.Domain
{
    public partial class UniversalMessage
    {
        public int MessageId { get; set; }

        public int ContentId { get; set; }

        public DateTime? MessageLiveDate { get; set; }

        public DateTime? MessageDeacitvatedDate { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? CreatedBy { get; set; }

        public virtual ContentRecord ContentRecord { get; set; }
    }
}
