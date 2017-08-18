namespace DH.Simplify.Core.Domain
{
    public partial class HelpDeskAttachnment
    {
        public int HelpDeskTicketId { get; set; }

        public int MediaAttachmentId { get; set; }

        public virtual MediaAttachment MediaAttachment { get; set; }

        public virtual HelpDeskTicket HelpDeskTicket { get; set; }
    }
}
