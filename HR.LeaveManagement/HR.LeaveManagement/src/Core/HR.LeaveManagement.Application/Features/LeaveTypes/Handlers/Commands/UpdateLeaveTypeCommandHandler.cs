using AutoMapper;
using FluentValidation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto.Validators;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using ValidationException = HR.LeaveManagement.Core.HR.LeaveManagement.Application.Exceptions.ValidationException;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateLeaveTypeValidator();
        var validationResult = await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);

        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult);

        var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);

        _mapper.Map(request.LeaveTypeDto, leaveType);

        await _leaveTypeRepository.Update(leaveType);

        return Unit.Value;
    }
}