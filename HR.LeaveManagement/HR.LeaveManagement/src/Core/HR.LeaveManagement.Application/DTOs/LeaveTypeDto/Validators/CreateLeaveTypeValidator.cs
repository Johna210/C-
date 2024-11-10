using FluentValidation;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto.Validators;

public class CreateLeaveTypeValidator : AbstractValidator<CreateLeaveTypeDto>
{
    public CreateLeaveTypeValidator()
    {
        Include(new ILeaveTypeDtoValidator());
    }
}