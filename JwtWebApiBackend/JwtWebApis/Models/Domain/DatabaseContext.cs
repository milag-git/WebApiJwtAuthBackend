using JwtWebApis.Models.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApis.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
                
        }

        public DbSet<TokenInfo> TokenInfo { get; set; }

        public DbSet<FileDetails> FileDetails { get; set; } = null!;

        public IEnumerable<FileDetails> SP_2mob_EMP_UPLOADPROJECTPHOTOS_READ_RecentProjects1(int TechEngr, DateTime startdate)
        {


            return this.FileDetails
                   .FromSqlRaw("EXEC [dbo].[2mob_EMP_UPLOADPROJECTPHOTOS_READ_RecentProjects1] @p0,@p1,@p2", TechEngr, startdate, startdate.AddDays(30))
                   .ToArray();

        }

        public DbSet<tblSchedule> tblSchedule { get; set; } = null!;
        public DbSet<tblProjects> tblProjects { get; set; } = null!;

    }
}
