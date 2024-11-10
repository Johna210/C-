namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;

public interface ILeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}