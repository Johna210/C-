using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Responses;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;

public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
{
    public CreateLeaveRequestDto LeaveRequest { get; set; }
}