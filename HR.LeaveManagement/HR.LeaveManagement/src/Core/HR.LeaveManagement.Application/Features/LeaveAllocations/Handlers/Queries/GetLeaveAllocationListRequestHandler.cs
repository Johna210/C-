using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class
    GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        _leaveAllocationRepository = repository;
        _mapper = mapper;
    }

    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request,
        CancellationToken cancellationToken)
    {
        var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
        return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
    }
}