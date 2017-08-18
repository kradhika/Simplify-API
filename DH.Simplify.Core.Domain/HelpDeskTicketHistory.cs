namespace DH.Simplify.Core.Domain
{
    public partial class HelpDeskTicketHistory
    {
        public int HelpDeskTicketHistoryId { get; set; }

        public int HelpDeskTicketId { get; set; }

        public string RemedyDescription { get; set; }

        public string RemedyStatus { get; set; }
    }
}
