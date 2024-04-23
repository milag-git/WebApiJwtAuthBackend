using JwtWebApis.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JwtWebApis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UploadProjectPhotosController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public UploadProjectPhotosController(IWebHostEnvironment env)
        {

            _env = env;
        }


        [HttpPost]

        public async Task<ActionResult<List<UploadResult>>> UploadFile(List<IFormFile> files)
        {
            List<UploadResult> uploadResults = new List<UploadResult>();
            foreach (var file in files)
            {
                var uploadResult = new UploadResult();
                string trustedFileNameForFileStorage;
                var untrustedFileName = file.FileName;
                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);
                trustedFileNameForFileStorage = Path.GetRandomFileName();

                var subpath = Path.Combine(_env.ContentRootPath, "Images");
                System.IO.Directory.CreateDirectory(subpath);
                var path = Path.Combine(subpath, trustedFileNameForFileStorage);

                await using FileStream fs = new(path, FileMode.Create);
                await file.CopyToAsync(fs);
                uploadResult.StoredFileName = trustedFileNameForFileStorage;
                uploadResults.Add(uploadResult);
            }
            return Ok(uploadResults);
        }

    }
}
