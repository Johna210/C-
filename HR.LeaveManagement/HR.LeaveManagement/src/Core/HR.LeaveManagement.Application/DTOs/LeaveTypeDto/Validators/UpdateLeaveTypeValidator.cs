using FluentValidation;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto.Validators;

public class UpdateLeaveTypeValidator : AbstractValidator<LeaveTypeDto>
{
    public UpdateLeaveTypeValidator()
    {
        Include(new ILeaveTypeDtoValidator());

        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required.}");
    }
}