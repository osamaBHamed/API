using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENOC.data
{
    public class SiteFacilities
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public bool Status { get; set; }

        public int SiteId { get; set; }
        public Facilities Facilities { get; set; }
    }
}
