using System.Collections.Generic;

namespace DH.Simplify.Core.Domain
{
    public partial class MediaAttachment
    {
        public MediaAttachment()
        {
            HelpDeskAttachnments = new HashSet<HelpDeskAttachnment>();
            ContentRecords = new HashSet<ContentRecord>();
        }

        public int MediaAttachmentId { get; set; }

        public byte[] AttachmentThumbnail { get; set; }

        public string AttachmentSourceId { get; set; }

        public string AttachmentSourceSystem { get; set; }

        public string AttachmentURL { get; set; }

        public virtual ICollection<HelpDeskAttachnment> HelpDeskAttachnments { get; set; }

        public virtual ICollection<ContentRecord> ContentRecords { get; set; }
    }
}
