using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
    Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
}