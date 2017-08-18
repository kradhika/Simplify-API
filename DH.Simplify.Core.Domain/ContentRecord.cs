using System;
using System.Collections.Generic;

namespace DH.Simplify.Core.Domain
{
    public partial class ContentRecord
    {
        public ContentRecord()
        {
            UniversalMessages = new HashSet<UniversalMessage>();
            MediaAttachments = new HashSet<MediaAttachment>();
        }

        public int ContentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string URL { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public virtual ICollection<UniversalMessage> UniversalMessages { get; set; }

        public virtual ICollection<MediaAttachment> MediaAttachments { get; set; }
    }
}
