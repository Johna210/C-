using FluentValidation;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators;

public class CreateLeaveAllocationValidator : AbstractValidator<CreateLeaveAllocationDto>
{
    public CreateLeaveAllocationValidator(ILeaveTypeRepository leaveTypeRepository)
    {
        Include(new ILeaveAllocationDtoValidator(leaveTypeRepository));
    }
}