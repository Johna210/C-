using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands;

public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;
    
    
    public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }
    
    public async Task<Unit> Handle(UpdateLeaveAllocationCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateLeaveAllocationValidator(_leaveTypeRepository);
        var validationResult = await validator.ValidateAsync(command.LeaveAllocationDto, cancellationToken);

        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult);
        
        var leaveAllocation = await _leaveAllocationRepository.Get(command.LeaveAllocationDto.Id);
        
        _mapper.Map(command.LeaveAllocationDto, leaveAllocation);
        
        await _leaveAllocationRepository.Update(leaveAllocation);
        
        return Unit.Value;
    }
}