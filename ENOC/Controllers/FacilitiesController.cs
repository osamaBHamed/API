using ENOC.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        [Route("LoadAll")]
        public List<Facilities> getFacilities()
        {
            ENOCContext context = new ENOCContext();
            return context.facilities.ToList();
        }

        [Route("SiteFacility")]
        public List<SiteFacilities> SiteFacility(int SiteId)
        {
            ENOCContext context = new ENOCContext();
            return context.siteFacilities.Where(s => s.SiteId == SiteId).ToList();
        }
    }
}
