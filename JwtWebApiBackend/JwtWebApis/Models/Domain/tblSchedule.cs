using Microsoft.EntityFrameworkCore;

namespace JwtWebApis.Models.Domain
{
    [Keyless]
    public partial class tblSchedule
    {
        public int RecId { get; set; }
        public DateTime FieldDate { get; set; }
        public string? FileNumber { get; set; }
        public int? TechEngr { get; set; }
        public int? Category { get; set; }
        public string? TaskCode { get; set; }

        public string? Description { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? Description3 { get; set; }
        public string? Description4 { get; set; }

        public DateTime? SchTime { get; set; }

        public string? AppTime { get; set; }
        public string? SpInst { get; set; }
        public double? OtapprovedHours { get; set; }
        public bool Finalized { get; set; }
        public string? TaskCodeSub { get; set; }
        public int? Overtime { get; set; }
        public int? OtapprovedBy { get; set; }
        public string? Otremarks { get; set; }
        public bool Cbaflag { get; set; }
        public string? ScanReportFilePath { get; set; }
        public string? JobCreatedByType { get; set; }
        public int? JobCreatedBy { get; set; }
        public DateTime? JobCreatedDateTime { get; set; }
        public string? JobModifiedByType { get; set; }
        public int? JobModifiedBy { get; set; }
        public DateTime? JobModifiedDateTime { get; set; }
        public int? FieldReportStatus { get; set; }
        public int FinalReportStatus { get; set; }
        public int TechEngrCertStatus { get; set; }
        public int? JobReviewStatus { get; set; }
        public int? JobReviewedBy { get; set; }
        public DateTime? JobReviewedDateTime { get; set; }
        public string? JobReviewRemarks { get; set; }
    }
}
