using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;

public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
{
    public int Id { get; set; }
}