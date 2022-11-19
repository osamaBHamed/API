using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ENOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        [Route("UploadImage")]
        public string UploadImage()
        {
            IFormFile file = HttpContext.Request.Form.Files[0];

            string name = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string path = Path.Combine(Directory.GetCurrentDirectory(), "/wwwroot", name);
            file.CopyTo(new FileStream(path, FileMode.Create));
            return name;
        }
    }
}
