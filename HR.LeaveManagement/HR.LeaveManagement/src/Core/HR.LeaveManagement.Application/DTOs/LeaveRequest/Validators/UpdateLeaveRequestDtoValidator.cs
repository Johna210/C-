using FluentValidation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators;

public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
{
    public UpdateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        Include(new ILeaveRequestDtoValidator(leaveTypeRepository));

        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required.}");
    }
}