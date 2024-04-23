using Microsoft.EntityFrameworkCore;

namespace JwtWebApis.Models.DTO
{
    [Keyless]
    public class FileDetails
    {
        public string? FileNumber { get; set; }

        public string? ProjectInfo { get; set; }
    }
}
