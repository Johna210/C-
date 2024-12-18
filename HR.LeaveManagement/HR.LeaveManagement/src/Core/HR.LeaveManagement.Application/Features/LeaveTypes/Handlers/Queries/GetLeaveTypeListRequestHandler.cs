using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypes = await _leaveTypeRepository.GetAll();
        return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
    }
}