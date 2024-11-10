using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest;

public class LeaveRequestDto: BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveTypeDto.LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; }
    public DateTime? DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}