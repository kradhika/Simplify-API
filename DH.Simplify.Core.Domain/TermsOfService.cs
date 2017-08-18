namespace DH.Simplify.Core.Domain
{
    public partial class TermsOfService
    {
        public int TermsOfServiceId { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
