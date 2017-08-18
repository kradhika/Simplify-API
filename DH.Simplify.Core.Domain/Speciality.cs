using System;
using System.Collections.Generic;

namespace DH.Simplify.Core.Domain
{
    public partial class Speciality
    {
        public Speciality()
        {
            ContentShares = new HashSet<ContentShare>();
        }
        
        public int SpecialityId { get; set; }

        public string SpecialityName { get; set; }

        public DateTime CreatedOn { get; set; }
        
        public string CreatedBy { get; set; }

        public virtual ICollection<ContentShare> ContentShares { get; set; }
    }
}
