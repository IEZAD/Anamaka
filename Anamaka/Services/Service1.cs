using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Anamaka.Services
{
    public static class Service1
    {
        public static string SaveFile(IHostingEnvironment _environment, IFormFile Upload)
        {
            var filename = Guid.NewGuid().ToString() + "_" + Upload.FileName;
            var file = Path.Combine(_environment.ContentRootPath, "Uploads", filename);

            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                Upload.CopyTo(fileStream);
            }

            return filename;
        }
    }
}
