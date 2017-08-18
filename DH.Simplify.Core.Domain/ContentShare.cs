using System;

namespace DH.Simplify.Core.Domain
{
    public partial class ContentShare
    {
        public int ContentShareId { get; set; }

        public int ContentId { get; set; }

        public int SpecialityId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public virtual Speciality Speciality { get; set; }
    }
}
