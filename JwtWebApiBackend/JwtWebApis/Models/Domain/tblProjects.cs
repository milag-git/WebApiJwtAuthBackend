using Microsoft.EntityFrameworkCore;

namespace JwtWebApis.Models.Domain
{
   
        [Keyless]
        public partial class tblProjects
        {
            public string ProjectNumber { get; set; } = null!;
            public string ProjectTitle { get; set; } = null!;
            public string? ProjectTitleShort { get; set; }
            public int ClientSysId { get; set; }
            public DateTime? StartDate { get; set; }
            public string? ProjectTypeCode { get; set; }
            public string? InspectionType { get; set; }
            public string? County { get; set; }
            public string? PrevailingWage { get; set; }
            public string? ProjectContactTitle { get; set; }
            public string? ProjectContactLastName { get; set; }
            public string? ProjectContactFirstName { get; set; }
            public string? ProjectContactPhone { get; set; }
            public string? ProjectContactFax { get; set; }
            public string? ProjectContactExt { get; set; }
            public string? ProjectContactMobile { get; set; }
            public string? ProjectContactPager { get; set; }
            public string? ProjectContactEmail { get; set; }
            public string? JobContactTitle { get; set; }
            public string? JobContactLastName { get; set; }
            public string? JobContactFirstName { get; set; }
            public string? JobContactPhone { get; set; }
            public string? JobContactExt { get; set; }
            public string? JobContactFax { get; set; }
            public string? JobContactMobile { get; set; }
            public string? JobContactPager { get; set; }
            public string? JobContactEmail { get; set; }
            public string? OtherContactTitle { get; set; }
            public string? OtherContactLastName { get; set; }
            public string? OtherContactFirstName { get; set; }
            public string? OtherContactPhone { get; set; }
            public string? OtherContactExt { get; set; }
            public string? OtherContactFax { get; set; }
            public string? OtherContactMobile { get; set; }
            public string? OtherContactPager { get; set; }
            public string? OtherContactEmail { get; set; }
            public string? JobSiteStreet { get; set; }
            public string? JobSiteCity { get; set; }
            public string? JobSiteState { get; set; }
            public string? JobSiteZip { get; set; }
            public string? JobSiteDirections { get; set; }
            public int? JobSiteMiles { get; set; }
            public int? GlsecprojectManager { get; set; }
            public string? GlsecproposalNumber { get; set; }
            public string? Remarks { get; set; }
            public DateTime? LastDateInvoiced { get; set; }
            public string? ReportTo { get; set; }
            public string? ReportType { get; set; }
            public string? ReportDueDate { get; set; }
            public string? ClientLogin { get; set; }
            public string? ClientPassword { get; set; }
            public double? MinimumChargeableTime { get; set; }
            public double? MinimumTripCharge { get; set; }
            public DateTime? DateLogged { get; set; }
            public int? DataEntryBy { get; set; }
            public DateTime? CreatedDate { get; set; }
            public int OfficeId { get; set; }
            public string? ClientProjectNo { get; set; }
        }
    
}
