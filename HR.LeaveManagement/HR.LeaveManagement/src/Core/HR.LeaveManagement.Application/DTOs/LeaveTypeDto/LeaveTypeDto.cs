using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;

public class LeaveTypeDto: BaseDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}