namespace HR.LeaveManagement.Core.HR.LeaveManagement.Domain.Common;

public abstract class BaseDomainEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; }
    public LeaveType LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int period { get; set; }
}