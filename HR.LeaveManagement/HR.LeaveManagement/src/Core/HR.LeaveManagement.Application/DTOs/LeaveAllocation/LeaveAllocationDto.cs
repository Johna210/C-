using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation;

public class LeaveAllocationDto: BaseDto, ILeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto.LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }   
}