using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
     {
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
    }   
}