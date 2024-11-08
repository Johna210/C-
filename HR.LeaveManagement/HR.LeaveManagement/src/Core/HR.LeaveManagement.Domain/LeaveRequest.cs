using HR.LeaveManagement.Core.HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

public class LeaveRequest : BaseDomainEntity
{
       public DateTime EndDate { get; set; }
       public LeaveType LeaveType { get; set; }
       public int LeaveTypeId { get; set; }
       public DateTime DateRequested { get; set; }
       public string RequestComments {get; set;}
       public DateTime DateActioned {get; set;}
       public bool? IsApproved {get; set;}
       public bool Cancelled {get; set;}
}