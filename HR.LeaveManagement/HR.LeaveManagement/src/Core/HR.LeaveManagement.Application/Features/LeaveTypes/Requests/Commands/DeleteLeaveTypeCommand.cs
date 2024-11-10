using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;

public class DeleteLeaveTypeCommand : IRequest
{
    public int Id { get; set; }
}