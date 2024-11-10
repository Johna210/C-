namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;

public class CreateLeaveTypeDto : ILeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}