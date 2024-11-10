using HR.LeaveManagement.Core.HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

public class LeaveType : BaseDomainEntity
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}