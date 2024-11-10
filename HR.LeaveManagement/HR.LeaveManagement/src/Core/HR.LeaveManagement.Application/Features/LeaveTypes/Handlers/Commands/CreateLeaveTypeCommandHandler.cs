using AutoMapper;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto.Validators;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreateLeaveTypeValidator();
        var validationResult = await validator.ValidateAsync(command.LeaveTypeDto, cancellationToken);

        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult);

        var leaveType = _mapper.Map<LeaveType>(command.LeaveTypeDto);
        leaveType = await _leaveTypeRepository.Add(leaveType);
        return leaveType.Id;
    }
}