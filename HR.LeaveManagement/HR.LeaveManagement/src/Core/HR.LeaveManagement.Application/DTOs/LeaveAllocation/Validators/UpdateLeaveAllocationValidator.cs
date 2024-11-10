using FluentValidation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;

public class UpdateLeaveAllocationValidator : AbstractValidator<UpdateLeaveAllocationDto>
{
    public UpdateLeaveAllocationValidator(ILeaveAllocationRepository leaveAllocationRepository)
    {
        Include(new ILeaveAllocationDtoValidator(leaveAllocationRepository));
        
        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required.}");
    }
}