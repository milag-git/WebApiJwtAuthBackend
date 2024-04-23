using JwtWebApis.Models.Domain;
using JwtWebApis.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWebApis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class FileDetailsController : ControllerBase
    {
        private readonly DatabaseContext _db;
        public FileDetailsController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet("{id}/{startdate}")]
        public IEnumerable<FileDetails> Get(int id, string startdate)
        {

            //int techengrparam = Convert.ToInt32(techengr);
            DateTime startdateparam = Convert.ToDateTime(startdate);
            var result = _db.SP_2mob_EMP_UPLOADPROJECTPHOTOS_READ_RecentProjects1(id, startdateparam);
            return result;


        }


    }
}
