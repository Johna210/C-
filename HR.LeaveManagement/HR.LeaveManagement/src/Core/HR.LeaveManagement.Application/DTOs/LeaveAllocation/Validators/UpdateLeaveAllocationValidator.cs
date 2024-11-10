using FluentValidation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;

public class UpdateLeaveAllocationValidator : AbstractValidator<UpdateLeaveAllocationDto>
{
    public UpdateLeaveAllocationValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        Include(new ILeaveAllocationDtoValidator(leaveTypeRepository));

        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required.}");
    }
}