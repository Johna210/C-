using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;
    
    public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }
    
    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
        return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
    }
}