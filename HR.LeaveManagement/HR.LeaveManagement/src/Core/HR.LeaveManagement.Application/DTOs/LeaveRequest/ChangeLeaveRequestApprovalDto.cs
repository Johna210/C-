using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest;

public class ChangeLeaveRequestApprovalDto : BaseDto
{
    public bool? Approved { get; set; }
}