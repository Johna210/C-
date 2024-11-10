using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Responses;
using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands;

public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;
    
    public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }
    
    public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateLeaveRequestDtoValidator(_leaveRequestRepository);
        var validationResult = await validator.ValidateAsync(request.LeaveRequest,cancellationToken);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creation Failed";
            response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            return response;
        }
        
        var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequest);
        leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
        
        response.Success = true; 
        response.Message = "Created Successfully";
        response.Id = leaveRequest.Id;
        
        return response;
    }
}